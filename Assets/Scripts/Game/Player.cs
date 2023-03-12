using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;
public class Player : MonoBehaviour
{
    public string MyName;
    public TextMeshProUGUI Daytext;
    public TextMeshProUGUI Money;
    public TextMeshProUGUI btntext;

    public TextMeshProUGUI[] statusText = new TextMeshProUGUI[4];

    public GameObject no_money_game;

    public GameObject no_money_shop;
    public GameObject no_space_shop;

    public GameObject default_dog;
    public GameObject Lion;
    public GameObject Tiger;
    public GameObject Elephant;
    public GameObject Dog;
    public GameObject Bear;
    public GameObject Horse;
    public GameObject Chimpanze;
    //public edit eded;

    public GameObject[] anima;

    public GameObject prision1;
    public GameObject prision2;

    public Transform[] prision_pos = new Transform[3];

    public ArrayList animals = new ArrayList();
    public ArrayList animals_status = new ArrayList();
    public static Player instance;

    public bool ischange = false;
    
    public GameObject game_ui;
    public GameObject show_ui;
    private bool show_ui_set;
    public GameObject obbj;

    int count = 1;
    public int money = 0;
    int chance;
    int rand_int = 0;
    int prision = 2;
    int i = 0;
    int j = 0;
    private void Awake()
    {
        Player.instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        // 배열 초기화
        for(int k = 0; k<4; k++)
        {
            animals.Add(null);
            animals_status.Add(null);
        }

        // 초반에 개 오브젝트 추가
        GameObject dog = Instantiate(default_dog, new Vector2(713, -220), Quaternion.identity);
        animals[0] = dog;
        animals_status.Add(statusText[0]);
        Animal cp = dog.GetComponent<Animal>();
        statusText[0].text = "레벨(" + cp.level.ToString() + " / 10)";
        statusText[0].text += "\n매력(" + cp.charm.ToString() + " / 100)";
        statusText[0].text += "\n체력(" + cp.health.ToString() + " / 100)";
        statusText[0].text += "\n컨디션(" + cp.condition.ToString() + " / 100)";
        statusText[0].text += "\n포만감(" + cp.satiety.ToString() + " / 100)";

        // 날자 갱신
        Money.text = money.ToString();
        Daytext.text = count.ToString();
        //eded.CheckRenderer();
    }
    
    // Update is called once per frame
    void Update()
    {

    }


    public void nextDay()
    {
        count += 1;

        if (money > 10000000)
        {
            SceneManager.LoadScene("EndScene");
        }
        if (count % 7 == 6)
        {
            btntext.text = "공연날";
        }
        else if (count % 7 == 0)
        {
            count++;
            circus();
            btntext.text = "다음날";
            j = 0;

            foreach (GameObject obj in animals)
            {
                if (obj != null)
                {
                    Animal data;
                    data = obj.GetComponent<Animal>();
                    if (data.level < 10)
                    {
                        data.level++;
                    }

                    reload_UI(j, data);
                    j++;
                }
            }
            showscene();
            foreach (GameObject obj in animals)
            {
                if (obj != null)
                {
                    curcusing(obj);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if(animals[i] != null)
                {
                    Animal ccp = ((GameObject)animals[i]).GetComponent<Animal>();
                    if (animals[i] != null)
                    {
                        ccp.condition -= Random.Range(1, 6);
                        ccp.satiety -= Random.Range(1, 6);
                        ccp.charm -= Random.Range(1, 6);
                        ccp.health -= Random.Range(1, 6);
                        if (ccp.condition < 0)
                        {
                            ccp.condition = 0;
                        }

                        if (ccp.satiety < 0)
                        {
                            ccp.satiety = 0;
                        }

                        if (ccp.charm < 0)
                        {
                            ccp.charm = 0;
                        }
                        reload_UI(i, ccp);
                        if (ccp.health < 0)
                        {
                            if(i == 0)
                            {
                                SceneManager.LoadScene("OverScene");
                            }
                            Destroy((GameObject)animals[i]);
                            animals[i] = null;
                            statusText[i].text = "";
                        }
                        if (ccp.condition == 0 || ccp.satiety == 0 || ccp.charm == 0)
                        {
                            changeGold(-5000);
                        }
                       
                    }
                }
               
            }
        }
        else
        {
            btntext.text = "다음날";
        }
        Daytext.text = count.ToString();

    }
    public void circus()
    {
        foreach (GameObject obj in animals)
        {
            if (obj != null)
            {
                Animal data;
                data = obj.GetComponent<Animal>();
                chance = (data.level + (data.health / 10) + (data.condition / 10) + (data.satiety / 10) + (data.charm / 10)) * 2;
                rand_int = Random.Range(0, 101);
                Debug.Log("chance " + chance);
                if (rand_int < chance)
                {
                    changeGold(data.expectedProfit() * 2);
                    money -= data.expectedProfit() * 10 / 100;
                    
                }
                else
                {
                    changeGold(data.expectedProfit() * 1);
                    money -= data.expectedProfit() * 5 / 100;
                }
            } 
        }
    }

    public int CheckCage(ArrayList ani)
    {
        
        int empty = 0;
        for (int i = 1; i < ani.Count; i++)
        {
            if (ani[i] == null)
            {
                empty = i;
                break;
            }
        }
        return empty;
        // empty 0이면 꽉찬거 
    }
    
    public int CheckCount(ArrayList ani)
    {
        int result = 0;
        for (int i = 0; i< ani.Count; i++)
        {
            if(ani[i] != null)
            {
                result++;
            }
        }
        return result;
    }
    public void buyAnimal(GameObject animal)
    {

        if (CheckCount(animals) < prision)
        {
            
            money -= 10000;
            int index = CheckCage(animals);
            GameObject ani = null;
            if (index == 1)
            {
                ani = Instantiate(animal, new Vector2(-696, -240), Quaternion.identity);
                animals[index] = ani;
            }
            else if (index == 2)
            {
                ani = Instantiate(animal, new Vector2(-214, -240), Quaternion.identity);
                animals[index] = ani;
            }
            else if (index == 3)
            {
                ani = Instantiate(animal, new Vector2(282, -240), Quaternion.identity);
                animals[index] = ani;
            }
            //GameObject ani = Instantiate(animal, new Vector2(0, 0), Quaternion.identity);
            //ani.transform.position = prision_pos[index - 1].position;
            //animals[index] = ani;
            animals_status.Add(statusText[index]);
            Animal cp = ani.GetComponent<Animal>();
            reload_UI(index, cp);
            Money.text = money.ToString();
        }
        else
        {
            no_space_shop.SetActive(true);
            Invoke("display_text", 1.0f);
        }

        Debug.Log(CheckCage(animals));
        Debug.Log("counting animals:" + CheckCount(animals));
        Debug.Log("prison: " + prision);
    }
    public void display_text()
    {
        no_space_shop.SetActive(false);
    }

    public void display_text2()
    {
        no_money_game.SetActive(false);
    }
    public void buyprision()
    {
        if (money >= 10000)
        {
            money = money - 10000;
            Money.text = money.ToString();
            
            
            if (prision <= 2)
            {
                prision1.SetActive(false);
            }
            if(prision == 3)
            {
                prision2.SetActive(false);
            }
            prision++;
        }
        else
        {
            no_money_game.SetActive(true);
            Invoke("display_text2", 1.0f);
        }
    }
    public void sell() 
    {
       
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if(ButtonName == "Sell1")
        {
            if(animals[1] != null)
            {
                Destroy((GameObject)animals[1]);
                animals[1] = null;
                statusText[1].text = "";
                changeGold(5000);
            }
        }
        else if (ButtonName == "Sell2")
        {
            if (animals[2] != null)
            {
                Destroy((GameObject)animals[2]);
                animals[2] = null;
                statusText[2].text = "";
                changeGold(5000);
            }
        }

        else if (ButtonName == "Sell3")
        {
            if (animals[3] != null)
            {
                Destroy((GameObject)animals[3]);
                animals[3] = null;
                statusText[3].text = "";
                changeGold(5000);
            }
        }
    }

    public void showscene()
    {
        if (!show_ui_set)
        {
            game_ui.SetActive(false);
            
            show_ui.SetActive(true);
            show_ui_set = true;
            ischange = true;
        }
        else
        {
            show_ui.SetActive(false);
            show_ui_set = false;

            game_ui.SetActive(true);
        }
    }

    public void gamescene()
    {
        show_ui.SetActive(false);
        show_ui_set = false;
        game_ui.SetActive(true);
        ischange = false;
    }

    public void care()
    {

  
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if (ButtonName == "Care1")
        {
            if(animals[1] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[1]).GetComponent<Animal>();

                cp.condition += Random.Range(1, 6);
                cp.satiety += Random.Range(1, 6);
                if (cp.condition > 100)
                {
                    cp.condition = 100;
                }

                if (cp.satiety > 100)
                {
                    cp.satiety = 100;
                }

                reload_UI(1, cp);

            }
        }
        else if (ButtonName == "Care2")
        {

            if(animals[2] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[2]).GetComponent<Animal>();

                cp.condition += Random.Range(1, 6);
                cp.satiety += Random.Range(1, 6);
                if (cp.condition > 100)
                {
                    cp.condition = 100;
                }

                if (cp.satiety > 100)
                {
                    cp.satiety = 100;
                }
                reload_UI(2, cp);
            }

        }
        else if (ButtonName == "Care3")
        {
            if (animals[3] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[3]).GetComponent<Animal>();

                cp.condition += Random.Range(1, 6);
                cp.satiety += Random.Range(1, 6);
                if (cp.condition > 100)
                {
                    cp.condition = 100;
                }

                if (cp.satiety > 100)
                {
                    cp.satiety = 100;
                }
                reload_UI(3, cp);
            }
            
            
        }
        else if (ButtonName == "Care4")
        {
            if (money >= 2000)
            {
                changeGold(-2000);
            }
            else
            {
                no_money_game.SetActive(true);
                Invoke("display_text2", 1.0f);
                return;
            }
            Animal cp = ((GameObject)animals[0]).GetComponent<Animal>();

            cp.condition += Random.Range(1, 6);
            cp.satiety += Random.Range(1, 6);
            if (cp.condition > 100)
            {
                cp.condition = 100;
            }

            if (cp.satiety > 100)
            {
                cp.satiety = 100;
            }
            reload_UI(0, cp);
        }
    }
 


    public void train()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;
        if (money >= 2000)
        {
            changeGold(-2000);
        }
        else
        {
            no_money_game.SetActive(true);
            Invoke("display_text2", 1.0f);
            return;
        }
        
        if (ButtonName == "Train1")
        {
            if (animals[1] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[1]).GetComponent<Animal>();

                cp.charm += Random.Range(1, 6);
                cp.health += Random.Range(1, 6);
                if (cp.charm > 100)
                {
                    cp.charm = 100;
                }

                if (cp.health > 100)
                {
                    cp.health = 100;
                }
                reload_UI(1, cp);

            }
        }
        else if (ButtonName == "Train2")
        {

            if (animals[2] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[2]).GetComponent<Animal>();

                cp.charm += Random.Range(1, 6);
                cp.health += Random.Range(1, 6);
                if (cp.charm > 100)
                {
                    cp.charm = 100;
                }

                if (cp.health > 100)
                {
                    cp.health = 100;
                }
                reload_UI(2, cp);
            }

        }
        else if (ButtonName == "Train3")
        {
            if (animals[3] != null)
            {
                if (money >= 2000)
                {
                    changeGold(-2000);
                }
                else
                {
                    no_money_game.SetActive(true);
                    Invoke("display_text2", 1.0f);
                    return;
                }
                Animal cp = ((GameObject)animals[3]).GetComponent<Animal>();

                cp.charm += Random.Range(1, 6);
                cp.health += Random.Range(1, 6);
                if (cp.charm > 100)
                {
                    cp.charm = 100;
                }

                if (cp.health > 100)
                {
                    cp.health = 100;
                }
                reload_UI(3, cp);
            }


        }
        else if (ButtonName == "Train4")
        {
            if (money >= 2000)
            {
                changeGold(-2000);
            }
            else
            {
                no_money_game.SetActive(true);
                Invoke("display_text2", 1.0f);
                return;
            }
            Animal cp = ((GameObject)animals[0]).GetComponent<Animal>();
            
            cp.charm += Random.Range(1,6);
            cp.health += Random.Range(1, 6);
            if (cp.charm > 100)
            {
                cp.charm = 100;
            }

            if (cp.health > 100)
            {
                cp.health = 100;
            }
            reload_UI(0, cp);
        }
    }
    public void reload_UI(int i , Animal cp)
    {
       
        statusText[i].text = "레벨(" + cp.level.ToString() + " / 10)";
        statusText[i].text += "\n매력(" + cp.charm.ToString() + " / 100)";
        statusText[i].text += "\n체력(" + cp.health.ToString() + " / 100)";
        statusText[i].text += "\n컨디션(" + cp.condition.ToString() + " / 100)";
        statusText[i].text += "\n포만감(" + cp.satiety.ToString() + " / 100)";
    }

    public void changeGold(int amount)
    {
        money += amount;
        Money.text = money.ToString();
        Debug.Log(money);
    }

    public void curcusing(GameObject animal)
    {
        if (animal.tag == "Dog")
        {
            animal.GetComponent<action>().Play();
        }
        animal.GetComponent<SpriteRenderer>().sortingLayerName = "front front front";
        animal.GetComponent<action>().moving();
        Invoke("gamescene", 3);
        animal.GetComponent<action>().stop();
       
    }
}

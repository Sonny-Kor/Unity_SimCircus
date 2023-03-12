using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject bear;
    public GameObject chimpanzee;
    public GameObject dog;
    public GameObject elephant;
    public GameObject horse;
    public GameObject lion;
    public GameObject tiger;

    public TextMeshProUGUI shop_money_ui;
    int rand_int;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MonkeyEgg()
    {

        if (Player.instance.money >= 10000)
        {
            rand_int = Random.Range(0, 101);
            if (rand_int < 45)
            {
                Player.instance.buyAnimal(chimpanzee);
            }
            else if (rand_int < 55)
            {
                Player.instance.buyAnimal(horse);
            }
            else if (rand_int < 70)
            {
                Player.instance.buyAnimal(bear);
            }
            else if (rand_int < 80)
            {
                Player.instance.buyAnimal(elephant);
            }
            else if (rand_int < 90)
            {
                Player.instance.buyAnimal(tiger);
            }
            else
            {
                Player.instance.buyAnimal(lion);
            }
        }
        else
        {
            Debug.Log("µ·ÀÌ ¾ø½À´Ï´Ù.");
            Player.instance.no_money_shop.SetActive(true);
            Invoke("display_text", 1.0f);
            
        }
        shop_money_ui.text = Player.instance.money.ToString();
    }
    private void display_text()
    {
        Player.instance.no_money_shop.SetActive(false);
    }
    public void HorseEgg()
    {
        if (Player.instance.money >= 10000)
        {
     
            rand_int = Random.Range(0, 101);
            if (rand_int < 20)
            {
                Player.instance.buyAnimal(chimpanzee);
            }
            else if (rand_int < 55)
            {
                Player.instance.buyAnimal(horse);
            }
            else if (rand_int < 70)
            {
                Player.instance.buyAnimal(bear);
            }
            else if (rand_int < 83)
            {
                Player.instance.buyAnimal(elephant);
            }
            else if (rand_int < 93)
            {
                Player.instance.buyAnimal(tiger);
            }
            else
            {
                Player.instance.buyAnimal(lion);
            }
        }
        else
        {
            Debug.Log("µ·ÀÌ ¾ø½À´Ï´Ù.");
            Player.instance.no_money_shop.SetActive(true);
            Invoke("display_text", 1.0f);
        }
        shop_money_ui.text = Player.instance.money.ToString();
    }
    public void BearEgg()
    {
        if (Player.instance.money >= 10000)
        {
            rand_int = Random.Range(0, 101);
            if (rand_int < 20)
            {
                Player.instance.buyAnimal(chimpanzee);
            }
            else if (rand_int < 35)
            {
                Player.instance.buyAnimal(horse);
            }
            else if (rand_int < 70)
            {
                Player.instance.buyAnimal(bear);
            }
            else if (rand_int < 83)
            {
                Player.instance.buyAnimal(elephant);
            }
            else if (rand_int < 93)
            {
                Player.instance.buyAnimal(tiger);
            }
            else
            {
                Player.instance.buyAnimal(lion);
            }
        }
        else
        {
            Debug.Log("µ·ÀÌ ¾ø½À´Ï´Ù.");
            Player.instance.no_money_shop.SetActive(true);
            Invoke("display_text", 1.0f);
        }
        shop_money_ui.text = Player.instance.money.ToString();
    }
    public void ElephantEgg()
    {
        if (Player.instance.money >= 10000)
        {
            rand_int = Random.Range(0, 101);
            if (rand_int < 5)
            {
                Player.instance.buyAnimal(chimpanzee);
            }
            else if (rand_int < 20)
            {
                Player.instance.buyAnimal(horse);
            }
            else if (rand_int < 35)
            {
                Player.instance.buyAnimal(bear);
            }
            else if (rand_int < 65)
            {
                Player.instance.buyAnimal(elephant);
            }
            else if (rand_int < 85)
            {
                Player.instance.buyAnimal(tiger);
            }
            else
            {
                Player.instance.buyAnimal(lion);
            }
        }
        else
        {

            Debug.Log("µ·ÀÌ ¾ø½À´Ï´Ù.");
            Player.instance.no_money_shop.SetActive(true);
            Invoke("display_text", 1.0f);
        }
        shop_money_ui.text = Player.instance.money.ToString();
    }
}

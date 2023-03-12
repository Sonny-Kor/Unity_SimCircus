using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameSceneControl : MonoBehaviour
{
    public GameObject game_ui;
    public GameObject option_ui;
    public GameObject shop_ui;
    public GameObject over_ui;
    public TextMeshProUGUI shop_money_ui;


    private bool option_ui_set;
    private bool shop_ui_set;

   
    // Start is called before the first frame update
    void Start()
    {
        option_ui_set = false;
        shop_ui_set = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OptionButton()
    {
        if (!option_ui_set)
        {
            game_ui.SetActive(false);

            option_ui.SetActive(true);
            option_ui_set = true;
        }
        else
        {
            option_ui.SetActive(false);
            option_ui_set=false;

            game_ui.SetActive(true);
        }
    }
    public void ShopButton()
    {
        if (!shop_ui_set)
        {
            game_ui.SetActive(false);

            shop_ui.SetActive(true);
            shop_ui_set = true;
            shop_money_ui.text = Player.instance.money.ToString();

        }
        else
        {
            shop_ui.SetActive(false);
            shop_ui_set = false;

            game_ui.SetActive(true);
        }
    }

    public void MainButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameOver()
    {
        game_ui.SetActive(false);
        option_ui.SetActive(false);

        over_ui.SetActive(true);
    }
}

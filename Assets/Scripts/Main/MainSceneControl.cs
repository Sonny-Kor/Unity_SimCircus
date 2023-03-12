using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneControl : MonoBehaviour
{
    public GameObject main_ui;
    public GameObject load_ui;
    public GameObject option_ui;

    private bool load_ui_set;
    private bool option_ui_set;
    // Start is called before the first frame update
    void Start()
    {
        load_ui_set=false;
        option_ui_set=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("StoryScene");

    }
    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadButoon()
    {
        if (load_ui_set)
        {
            load_ui.SetActive(false);
            load_ui_set = false;

            main_ui.SetActive(true);
        }
        else
        {
            main_ui.SetActive(false);

            load_ui.SetActive(true);
            load_ui_set = true;
        }
    }

    public void OptionButton()
    {
        if (option_ui_set)
        {
            option_ui.SetActive(false);
            option_ui_set = false;

            main_ui.SetActive(true);
        }
        else
        {
            main_ui.SetActive(false);

            option_ui.SetActive(true);
            option_ui_set = true;
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}

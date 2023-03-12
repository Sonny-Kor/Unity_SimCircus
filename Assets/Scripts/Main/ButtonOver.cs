using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonOver : MonoBehaviour
{
    public TextMeshProUGUI[] text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartEnter()
    {
        text[0].fontStyle = FontStyles.Bold | FontStyles.Underline;
    }
    public void LoadEnter()
    {
        text[1].fontStyle = FontStyles.Bold | FontStyles.Underline;
    }
    public void OptionEnter()
    {
        text[2].fontStyle = FontStyles.Bold | FontStyles.Underline;
    }
    public void ExitEnter()
    {
        text[3].fontStyle = FontStyles.Bold | FontStyles.Underline;
    }
    public void MouseExit4()
    {
        for (int i = 0; i < 4; i++)
            text[i].fontStyle = FontStyles.Bold;
    }
}

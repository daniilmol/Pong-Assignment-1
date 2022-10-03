using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CommandPrompt : MonoBehaviour
{
    public GameObject console;
    // public TextMeshProUGUI winConInputText;
    public winCondition win;
    public int goalNumber = 0;
    public GameObject winGoal;
    public GameObject ConditionConfirmButton;

    public void Awake()
    {
        ConditionConfirmButton.GetComponent<Button>().onClick.AddListener(() =>
        {
            setConditon();
        });

    }
    public void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            //Instantiate(console);
            openConsole();
            Debug.Log("Open");
            
        }


    }

    public void openConsole()
    {
        console.GetComponent<Renderer>().enabled = true;
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(true);
        }

    }
    public void setConditon() {
        goalNumber = int.Parse(winGoal.GetComponent<TMP_InputField>().text);
        win.setWinCondition(goalNumber);
        Debug.Log(goalNumber);
    }

    //public void OnConfirmClick() {
    //    ConditionConfirmButton.GetComponent<Button>().onClick.AddListener(() =>
    //    {
    //        setConditon();
    //    }); 
    //}

    public void exit()
    {
        //console.SetActive(false);
        console.GetComponent<Renderer>().enabled = false;
        for (int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(false);
        }
    }


}

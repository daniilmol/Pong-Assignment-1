using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPrompt : MonoBehaviour
{
    public GameObject console;

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

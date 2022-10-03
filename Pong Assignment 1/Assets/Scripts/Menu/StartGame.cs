using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public bool singleFlag = false;
    public bool mutilFlag = false;
    public static StartGame sg;

    private void Awake()
    {
        sg = this;
    }

    public void startGame(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void setSingleFlag()
    {
        singleFlag = true;
    }

    public void setMurilFlag()
    {
        mutilFlag = true;
    }
}

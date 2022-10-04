using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PaddleControllerTwo : PaddleController
{
    public TextMeshProUGUI redScore;
    private float position;
    private void Start()
    {
        playerID = 2;
        score = 0;
        redScore.text = 0.ToString();
    }
    private void FixedUpdate()
    {
        AIControl();
        PlayerControl();
        redScore.text = getScore().ToString();
        checkWin();
    }

    private void AIControl() 
    {
        if (StartGame.sg.singleFlag)
        {
            position = FindObjectOfType<Ball>().ballYLocation;
            Vector3 v3 = new Vector3(0, position, 0);
            transform.Translate(v3 * 0.05f);
        }
    }

    private void PlayerControl()
    {
        if (StartGame.sg.mutilFlag)
        {
            Vector2 v2 = movement2.ReadValue<Vector2>();
            Vector3 v3 = new Vector3(0, v2.y, 0);
            transform.Translate(v3 * 0.05f);
        }
    }
}

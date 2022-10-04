using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PaddleControllerOne : PaddleController
{
    public TextMeshProUGUI blueScore;
    private void Start()
    {
        playerID = 1;
        score = 0;
        blueScore.text = 0.ToString();
    }
    private void FixedUpdate()
    {
        Vector2 v2 = movement.ReadValue<Vector2>();
        Vector3 v3 = new Vector3(0, v2.y, 0);
        transform.Translate(v3 * 0.05f);
        blueScore.text = getScore().ToString();
        checkWin();
    }
    
}

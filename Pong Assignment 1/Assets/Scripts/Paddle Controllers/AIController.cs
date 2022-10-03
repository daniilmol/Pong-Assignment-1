using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : PaddleController
{
    private float position = 0;
    private void Start()
    {
        playerID = 2;

        if (StartGame.sg.mutilFlag)
        {
            disableAiMode();
        }
    }
    private void FixedUpdate()
    {
        position = FindObjectOfType<Ball>().ballYLocation;

        Vector3 v3 = new Vector3(0, position, 0);
        transform.Translate(v3 * 0.05f);
    }

    private void disableAiMode()
    {
        this.enabled = false;
    }
}

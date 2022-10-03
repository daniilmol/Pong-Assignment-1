using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControllerTwo : PaddleController
{
    private void Start()
    {
        playerID = 2;

        if (StartGame.sg.singleFlag)
        {
            disableMultiMode();
        }
    }
    private void FixedUpdate()
    {
        Vector2 v2 = movement2.ReadValue<Vector2>();
        Vector3 v3 = new Vector3(0, v2.y, 0);
        transform.Translate(v3 * 0.05f);
    }

    private void disableMultiMode()
    {
        this.enabled = false;
    }
}

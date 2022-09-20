using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float speed = 4;
        GetComponent<Rigidbody>().velocity = Random.onUnitSphere * speed;
    }

    // Update is called once per frame

    float timeLeft;
    Color targetColor;

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            // transition complete
            // assign the target color
            GetComponent<Light>().color = targetColor;

            // start a new transition
            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = 3.0f;
        }
        else
        {
            // transition in progress
            // calculate interpolated color
            GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, targetColor, Time.deltaTime / timeLeft);

            // update the timer
            timeLeft -= Time.deltaTime;
        }
    }
}

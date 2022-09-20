using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float colorSpeed = 3f; 
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Random.onUnitSphere * 4f;
    }


    float timeLeft;
    Color targetColor;

    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            GetComponent<Light>().color = targetColor;

            targetColor = new Color(Random.value, Random.value, Random.value);
            timeLeft = colorSpeed;
        }
        else
        {
            GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, targetColor, Time.deltaTime / timeLeft);

            timeLeft -= Time.deltaTime;
        }
    }
}

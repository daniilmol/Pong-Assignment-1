using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    protected InputActions inputActions;
    protected InputAction movement;
    protected InputAction movement2;
    protected Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputActions = new InputActions();
        movement = inputActions.Paddle.Movement;
        movement2 = inputActions.Paddle.Movement2;
    }

    private void OnEnable()
    {
        movement.Enable();
        movement2.Enable();

    }

    private void OnDisable()
    {
        movement.Disable();
        movement2.Enable();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PaddleController : MonoBehaviour
{
    protected InputActions inputActions;
    protected InputAction movement;
    protected InputAction movement2;
    protected Rigidbody rb;
    public int playerID;
    public int score = 0;
    public CommandPrompt command;
    public TextMeshProUGUI winCon;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball") {
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
        }
    }
    private void reflectBall() { 
    
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        inputActions = new InputActions();
        movement = inputActions.Paddle.Movement;
        movement2 = inputActions.Paddle.Movement2;
        Time.timeScale = 0;
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

    public int getPlayerID() {
        return playerID;
    }

    public void incrementScore() {
        score++;
        Debug.Log("Player " + playerID + ": " + score);
    }
    public int getScore()
    {
        return score;
    }
    public void checkWin()
    {
        if (score >= command.getWinCondition() && score >= 1) {
            Debug.Log(playerID);
            Time.timeScale = 0;
            if (playerID == 1)
            {
                winCon.GetComponent<TextMeshProUGUI>().text = "Blue Player Wins!";
            }
            else {
                winCon.GetComponent<TextMeshProUGUI>().text = "Red Player Wins!";
            }
            
        }
    }
}

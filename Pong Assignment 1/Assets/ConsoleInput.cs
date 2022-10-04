using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
using TMPro;

public class ConsoleInput : MonoBehaviour
{
    public string cmd1 = "bg_color ";
    public string cmd2 = "p1_score ";
    public string cmd3 = "p2_score ";
    public string cmd4 = "win_condation ";
    public GameObject BackGround;
    public int PlayerOneScore;
    public int PlayerTwoScore;
    public int WinCondition;

    private void ReadInput(string inputText) {
        if (inputText.StartsWith(cmd1)) {
            SetbackGroundColor(inputText.Replace(cmd1, ""));
        }
        if (inputText.StartsWith(cmd2)) {
            SetPlayerScore(1, Int16.Parse(inputText.Replace(cmd2, "")));
        }
        if (inputText.StartsWith(cmd3)) {
            SetPlayerScore(2, Int16.Parse(inputText.Replace(cmd3, "")));
        }
        if (inputText.StartsWith(cmd4)) {
            SetWinCondation(Int16.Parse(inputText.Replace(cmd4, "")));
        }
    }

    public void SetbackGroundColor(string color) {
        Color newColor;
        if (ColorUtility.TryParseHtmlString(color, out newColor)) {
            BackGround.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }

    public void SetPlayerScore(int id, int score) {
        if (id == 1) {
            PlayerOneScore = score;
        }
        if (id == 2) {
            PlayerTwoScore = score;
        }
    }

    public void SetWinCondation(int score) {
        WinCondition = score;
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Return)) {
            string text = this.GetComponent<TMP_InputField>().text;
            if (text != "") {
                ReadInput(text);
                this.GetComponent<TMP_InputField>().text = "";
            }
        }
    }
}

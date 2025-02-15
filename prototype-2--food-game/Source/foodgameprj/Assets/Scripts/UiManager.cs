﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text scoreText;
    public Text heartText;
    public int score;
    public EventSystemCustom eventSystem;

    void Start()
    {
        eventSystem.OnEatFood.AddListener(UpdateScoreText);
        eventSystem.onHeartLost.AddListener(UpdateHeartText);
        eventSystem.onHeartIncrease.AddListener(UpdateHeartTextIncrease);
    }

    public void UpdateScoreText()
    {
        Debug.Log("UPDATE SCORE");
        score = GameObject.Find("Player").GetComponent<PlayerController>().playerScore;
        scoreText.text = score.ToString();
    }

    public void UpdateHeartText()
    {
        Debug.Log("UPDATE HEART");
        int newTextValue = int.Parse(heartText.text) - 1;
        heartText.text = newTextValue.ToString();
    }

    public void UpdateHeartTextIncrease()
    {
        int newTextValue = int.Parse(heartText.text) + 1;
        heartText.text = newTextValue.ToString();
    }
}
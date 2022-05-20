using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI gameOverScore;
    private void OnEnable()
    {
        Enemy.Score += IncreaseScore;
        PlayerHealth.OnDeath += SetGameOverText;
    }
    
    private void OnDisable()
    {
        Enemy.Score -= IncreaseScore;
        PlayerHealth.OnDeath -= SetGameOverText;
    }

    private void IncreaseScore()
    {
        ++score;
        text.text = "Score : " + score.ToString();
    }

    private void SetGameOverText()
    {
        gameOverScore.text = "Score : " + score.ToString();
    }
}

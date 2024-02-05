using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class Score
{
    public static int score;
    

    public static int GetScore()
    {
        return score;
    }

    public static void SetScore(int scored)
    {
        if (score == scored)
        {
            return;
        }
        score = scored;
    }

    public static void IncreaseScore()
    {
        score++;
    }  

}

/*
 * private int score;
public TextMeshProUGUI scoreText;
void Start() {
StartCoroutine(SpawnTarget());
score = 0;
scoreText.text = "Score: " + score; }
  */

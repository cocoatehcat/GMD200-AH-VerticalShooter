using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreDisplay : MonoBehaviour
{
    public  TextMeshProUGUI scoreText;
    public void Start()
    {
        Score.SetScore(0);
        scoreText.text = Score.GetScore().ToString();
    }

    public void Update()
    {
        var ahh = Score.GetScore();
        scoreText.text = ahh.ToString();
    }
    /*public void UpdateScore(int scoreToAdd)
    {
        var ahh = Score.GetScore() + scoreToAdd;
        scoreText.text = ahh.ToString();
    } */
}

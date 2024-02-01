using System.Collections;
using System.Collections.Generic;
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

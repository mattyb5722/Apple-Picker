using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour {

    public List<int> HighScores = new List<int>();

    public void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            string title = "High Score: " + i;
            if (!PlayerPrefs.HasKey(title))
            {
                PlayerPrefs.SetInt(title, 0);
            }
            HighScores.Add(PlayerPrefs.GetInt(title));
        }
    }

    public void NewHighScore(int score)
    {
        for (int i = 0; i < HighScores.Count; i++)
        {
            if (score < HighScores[i])
            {
                PlayerPrefs.SetInt("High Score: " + i, score);
                print("New High Score");
                break;
            }
        }
    }
}

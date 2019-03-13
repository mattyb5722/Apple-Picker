using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour {

    public static HighScoreManager instance = null;

    private List<int> HighScores = new List<int>();

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
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
        //print(HighScores.Count);
        for (int i = 0; i < HighScores.Count; i++)
        {
            if (score > HighScores[i])
            {
                PlayerPrefs.SetInt("High Score: " + i, score);
                print("New High Score");
                break;
            }
        }
    }
    public List<int> getHighScores()
    {
        return HighScores;
    }
}

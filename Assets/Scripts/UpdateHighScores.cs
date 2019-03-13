using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHighScores : MonoBehaviour {

    public GameObject highScoresManager;

	private void Start () {
        List<int> highScores = highScoresManager.GetComponent<HighScoreManager>().HighScores;
        print("highScores.Count: " + highScores.Count);
        //Text scores = GetComponentInChildren<Text>();
        Text [] scores = GetComponentsInChildren<Text>();
        for (int i = 1; i <= 10; i++)
        {
            print("i: " + i);
            scores[i].text = "1: " + highScores[i - 1];
        }
        //scores[0].text = "GHGHGH";
    }
}

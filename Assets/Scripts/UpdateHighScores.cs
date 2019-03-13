using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHighScores : MonoBehaviour {

	private void Awake () {
        List<int> highScores = HighScoreManager.instance.getHighScores();
        Text [] scores = GetComponentsInChildren<Text>();
        for (int i = 0; i < 10; i++)
        {
            scores[i].text = i+1+": " + highScores[i];
        }
    }
}

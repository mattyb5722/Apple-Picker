using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void ChangeScene(string sceneName)
    {

        if (sceneName == "" || sceneName == null)
        {
            Debug.LogWarning("Empty Scene Name");
        }
        else if (sceneName == "Quit")
        {
            Application.Quit();
        }
        else
        {
            Debug.Log(sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}

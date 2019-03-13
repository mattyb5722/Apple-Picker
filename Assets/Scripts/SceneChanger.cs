using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

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
            SceneManager.LoadScene(sceneName);
        }
    }
}

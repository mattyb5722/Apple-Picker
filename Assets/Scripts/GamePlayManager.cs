using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour {
    /// <summary>
    /// Manages game play of the game
    /// </summary>
    public GameObject tree;
    public GameObject player;
    public GameObject appleSprite;
    private static List<GameObject> apples = new List<GameObject>(); // List of falling apples
    private float appleRandomChange = .02f;  // Chance of apple dropping
    public Text playerLifesText;
    private int playerLifes = 3;
    public Text playerScoreText;
    private static int playerScore = 0;
 
    private void Update()
    {
        playerScoreText.text = "Score: " + playerScore; // Updates score
        playerLifesText.text = "Lives: " + playerLifes; // Updates lives
    }

    private void FixedUpdate()
    {
        if (Random.value <= appleRandomChange)
        {                                   // Apple is being made
            GameObject Temp = Instantiate(appleSprite); // Make an apple
            Temp.SetActive(true);           // See the Apple to visible
            Temp.transform.position = new Vector3(tree.transform.position.x, tree.transform.position.y, 0f); 
                                            // Set new location of apple
            apples.Add(Temp);               // Add new apple to list of falling apples
        }
        for (int i = 0; i < apples.Count; i++)
        {                                   // All the falling apples
            if (apples[i].transform.position.y <= -4)
            {                               // If they have hit the ground
                DeleteApple(apples[i]);     // Destroy apple object
                playerLifes -= 1;           // Player loses a life
                if (playerLifes <= 0)
                {                           // Player is dead
                    Restart();              // Restart game
                }
            }
        }
    }

    // Restart Game
    private void Restart()
    {                                       
        SceneChanger.instance.ChangeScene("Game Over"); // Change Scene
        HighScoreManager.instance.NewHighScore(playerScore); // Update High Scores

        for (int i = 0; i < apples.Count; i++)
        {
            Destroy(apples[i]);             // Destroy all apple objects
        }
        apples.Clear();                     // Clear list
        playerLifes = 3;                    // Reset lives
        playerScore = 0;                    // Reset score
        player.transform.position = new Vector3(0f, -4f, 0f); // Reset players location
        tree.transform.position = new Vector3(0f, 3f, 0f); // Reset tree location
    }

    public static void PlayerScore(GameObject apple)
    {                                       // Player has caught an apple
        playerScore += 10;                  // Incroment score
        SFXManager.instance.Catch();        // Play sound effect
        DeleteApple(apple);                 // Delete apple that was caught
    }

    public static void DeleteApple(GameObject apple)
    {
        Destroy(apple);                     // Destroy apple
        apples.Remove(apple);               // Remove apple from list
    } 
}

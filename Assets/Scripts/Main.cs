using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {
    /// <summary>
    /// Manages the UI objects and the creation and deletion of apples
    /// </summary>
    public GameObject Tree;
    public GameObject Player;
    public GameObject Apple_Sprite;
    private static List<GameObject> Apples = new List<GameObject>(); // List of falling apples
    private float appleRandomChange = .02f;  // Chance of apple dropping
    public Text playerLifesText;
    private int playerLifes = 3;
    public Text playerScoreText;
    private static int playerScore = 0;
    public Text highScoreText;
    private int highScore = 0;
    public Text startText;

    private void Start()
    {
        Time.timeScale = 0;                 // Game is paused
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {                                   // Game starts when the player clicks
            Time.timeScale = 1;
            startText.enabled = false;      // Start text disappears
        }
        playerScoreText.text = "Score: " + playerScore; // Updates score
        playerLifesText.text = "Lives: " + playerLifes; // Updates lives
    }
    private void FixedUpdate()
    {
        if (Random.value <= appleRandomChange)
        {                                   // Apple is being made
            GameObject Temp = Instantiate(Apple_Sprite); // Make an apple
            Temp.SetActive(true);           // See the Apple to visible
            Temp.transform.position = new Vector3(Tree.transform.position.x, Tree.transform.position.y, 0f); 
                                            // Set new location of apple
            Apples.Add(Temp);               // Add new apple to list of falling apples
        }
        for (int i = 0; i < Apples.Count; i++)
        {                                   // All the falling apples
            if (Apples[i].transform.position.y <= -4)
            {                               // If they have hit the ground
                DeleteApple(Apples[i]);     // Destroy apple object
                playerLifes -= 1;           // Player loses a life
                if (playerLifes <= 0)
                {                           // Player is dead
                    Restart();              // Restart game
                }
            }
        }
    }
    private void Restart()
    {                                       // Restart Game
        Time.timeScale = 0;                 // Pause game
        if (playerScore > highScore)
        {
            highScore = playerScore;        // New High Score
            highScoreText.text = "High Score: " + highScore;
        }
        for (int i = 0; i < Apples.Count; i++)
        {
            Destroy(Apples[i]);             // Destroy all apple objects
        }
        Apples.Clear();                     // Clear list
        startText.enabled = true;           // Enable start text
        playerLifes = 3;                    // Reset lives
        playerScore = 0;                    // Reset score
        Player.transform.position = new Vector3(0f, -4f, 0f); // Reset players location
        Tree.transform.position = new Vector3(0f, 3f, 0f); // Reset tree location
        
    }

    public static void PlayerScore(GameObject apple)
    {                                       // Player has caught an apple
        playerScore += 10;                  // Incroment score
        SFXManager.Catch();                 // Play sound effect
        DeleteApple(apple);                 // Delete apple that was caught
    }

    public static void DeleteApple(GameObject apple)
    {
        Destroy(apple);                     // Destroy apple
        Apples.Remove(apple);               // Remove apple from list
    }
    
}

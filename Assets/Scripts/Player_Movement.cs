using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
    /// <summary>
    /// Manages the player's movement
    /// </summary>
    private float boarder = 8.25f; // Edge of the screen

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {                                       // Moving right
            float new_x = transform.position.x + .1f;
            if (new_x > boarder)
            {                                   // Player is at the edge of the screen
                new_x = boarder;
            }
            transform.position = new Vector3(new_x, -4f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {                                       // Moving left
            float new_x = transform.position.x - .1f;
            if (new_x < (-1* boarder))
            {                                   // Player is at the edge of the screen
                new_x = (-1 * boarder);
            }
            transform.position = new Vector3(new_x, -4f, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GamePlayManager.PlayerScore(collision.gameObject); // Player has collected an apple
    }
}

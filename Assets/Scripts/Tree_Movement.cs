using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_Movement : MonoBehaviour {
    /// <summary>
    /// Manages the Tree's movement
    /// </summary>
    private float directionChangeChance = .05f; // Chance of the tree changing directions
    private float boarder = 7.5f;               // Edge of the Screen
    private int direction = 1;                  // Direction the tree is traveling

    private void FixedUpdate()
    {
        float speed = Random.Range(0, .2f);     // Spead of the tree
        if (Random.value <= directionChangeChance || transform.position.x > boarder || transform.position.x < (-1* boarder))
        {
            direction *= -1;
        }
        float new_x = transform.position.x + (speed*direction); // New x location of the tree
        if (new_x > boarder)
        {                                       // Tree is too far right
            new_x = boarder;
        }else if (new_x < (-1* boarder))
        {                                       // Tree is too far left
            new_x = (-1 * boarder);
        }
        transform.position = new Vector3(new_x, 3f, 0); // Move tree
    }
}

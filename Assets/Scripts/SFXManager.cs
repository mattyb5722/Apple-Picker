using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    /// <summary>
    /// This script manages the background music as well as the 
    /// sound made when an apple is caught.
    /// </summary>

    [Header("Background")]
    public AudioSource backgroundSource;    // Source of background music
    [Range(0, 1)]
    public float backgroundVolume;          // Volume of background music

    [Header("Catching Sound Effect")]
    public AudioSource cacthingSource;      // Source of cacthing sound
    public AudioClip cacthingClip;          // Clip of cacthing sound
    [Range(0, 1)]
    public float cacthingVolume;            // Volume of cacthing sound

    private static System.Boolean caught = false;

    public void Start()
    {
        backgroundSource.Play();            // Play background music
    }

    public void Update()
    {
        cacthingSource.volume = cacthingVolume; // Change button volume
        backgroundSource.volume = backgroundVolume; // Change background volume
        if (caught)
        {
            cacthingSource.PlayOneShot(cacthingClip); // Play button sound
            caught = false;
        }
    }
    public static void Catch()
    {
        caught = true;
    }
}

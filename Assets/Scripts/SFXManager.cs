using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    /// <summary>
    /// This script manages the background music as well as the 
    /// sound made when an apple is caught.
    /// </summary>
 
    public static SFXManager instance = null; // Instance of this class

    [Header("Background")]
    public AudioSource backgroundSource;    // Music Sourse
    [Range(0, 1)]
    public float backgroundVolume;          // Music Volume

    [Header("Catching Sound Effect")]
    public AudioSource cacthingSource;      // Effect Sourse
    public AudioClip cacthingClip;          // Effect Clip
    [Range(0, 1)]
    public float cacthingVolume;            // Effect Volume

    public void Awake()
    {
        // Creates instance of this class
        if (instance == null){ instance = this; }
        else{ Destroy(gameObject); }

        // Creates player volume preferences (Music)
        if (!PlayerPrefs.HasKey("Background Volume"))
        {
            PlayerPrefs.SetFloat("Background Volume", backgroundVolume); // Defualt Value
        }
        instance.backgroundVolume = PlayerPrefs.GetFloat("Background Volume"); // Get past perference
        instance.backgroundSource.volume = instance.backgroundVolume; // Set Music Volume


        // Creates player volume preferences (Effects)
        if (!PlayerPrefs.HasKey("Effect Volume"))
        {
            PlayerPrefs.SetFloat("Effect Volume", cacthingVolume); // Defualt Value
        }
        instance.cacthingVolume = PlayerPrefs.GetFloat("Effect Volume");  // Get past perference
        instance.cacthingSource.volume = instance.cacthingVolume; // Set Effect Volume
    }

    // Increaing the Music Volume
    public void BackgroundVolumeUp()
    {
        if (instance.backgroundVolume + .1f <= 1.1)
        { 
            instance.backgroundVolume += .1f; // Increase 
            PlayerPrefs.SetFloat("Background Volume", instance.backgroundVolume); // Set player preference
            instance.backgroundSource.volume = instance.backgroundVolume; // Set Music Volume
        }

    }
    // Decreasing the Music Volume
    public void BackgroundVolumeDown()
    {
        if (instance.backgroundVolume - .1f >= 0)
        {
            instance.backgroundVolume -= .1f;
            PlayerPrefs.SetFloat("Background Volume", instance.backgroundVolume); // Set player preference
            instance.backgroundSource.volume = instance.backgroundVolume; // Set Music Volume
        }
    }
    // Increaing the Effect Volume
    public void EffectVolumeUp()
    {
        if (instance.cacthingVolume + .1f <= 1.1)
        {
            instance.cacthingVolume += .1f; 
            PlayerPrefs.SetFloat("Effect Volume", instance.cacthingVolume); // Set player preference
            instance.cacthingSource.volume = instance.cacthingVolume; // Set Effect Volume
        }

    }
    // DEcreasing the Effect Volume
    public void EffectVolumeDown()
    {
        if (instance.cacthingVolume - .1f >= 0)
        {
            instance.cacthingVolume -= .1f;
            PlayerPrefs.SetFloat("Effect Volume", instance.cacthingVolume); // Set player preference
            instance.cacthingSource.volume = instance.cacthingVolume; // Set Effect Volume
        }

    }
    // Sound of catching an apple
    public void Catch()
    {
        cacthingSource.PlayOneShot(cacthingClip);
    }
}

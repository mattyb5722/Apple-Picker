using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    /// <summary>
    /// This script manages the background music as well as the 
    /// sound made when an apple is caught.
    /// </summary>
    public static SFXManager instance = null;

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

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (!PlayerPrefs.HasKey("Background Volume"))
        {
            PlayerPrefs.SetFloat("Background Volume", backgroundVolume);
        }
        instance.backgroundVolume = PlayerPrefs.GetFloat("Background Volume");
        instance.backgroundSource.volume = instance.backgroundVolume;
        if (!PlayerPrefs.HasKey("Effect Volume"))
        {
            PlayerPrefs.SetFloat("Effect Volume", cacthingVolume);
        }
        instance.cacthingVolume = PlayerPrefs.GetFloat("Effect Volume");
        instance.cacthingSource.volume = instance.cacthingVolume; // Change button volume
        //instance.backgroundSource.Play();            // Play background music
    }

    public void BackgroundVolumeUp()
    {
        if (instance.backgroundVolume + .1f <= 1.1)
        { 
            instance.backgroundVolume += .1f;
            PlayerPrefs.SetFloat("Background Volume", instance.backgroundVolume);
            instance.backgroundSource.volume = instance.backgroundVolume; // Change background volume
        }

    }

    public void BackgroundVolumeDown()
    {
        if (instance.backgroundVolume - .1f >= 0)
        {
            instance.backgroundVolume -= .1f;
            PlayerPrefs.SetFloat("Background Volume", instance.backgroundVolume);
            instance.backgroundSource.volume = instance.backgroundVolume; // Change background volume
        }
    }

    public void EffectVolumeUp()
    {
        if (instance.cacthingVolume + .1f <= 1.1)
        {
            instance.cacthingVolume += .1f;
            PlayerPrefs.SetFloat("Effect Volume", instance.cacthingVolume);
            instance.cacthingSource.volume = instance.cacthingVolume; // Change button volume
        }

    }

    public void EffectVolumeDown()
    {
        if (instance.cacthingVolume - .1f >= 0)
        {
            instance.cacthingVolume -= .1f;
            PlayerPrefs.SetFloat("Effect Volume", instance.cacthingVolume);
            instance.cacthingSource.volume = instance.cacthingVolume; // Change button volume
        }

    }

    public void Update()
    {
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

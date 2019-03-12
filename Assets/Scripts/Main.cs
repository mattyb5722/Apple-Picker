using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Main : MonoBehaviour {

    public GameObject Manager;
    public GameObject Canvas;
    public GameObject Audio;
    public GameObject Camera;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(Manager);
        DontDestroyOnLoad(Canvas);
        DontDestroyOnLoad(Audio);
        DontDestroyOnLoad(Camera);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    //public static DontDestroy instance = null;

    private void Awake()
    {
        /*
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        */
        DontDestroyOnLoad(this.gameObject);
    }
}

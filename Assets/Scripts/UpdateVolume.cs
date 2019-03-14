using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateVolume : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        float backgroundVolume = SFXManager.instance.backgroundVolume;
        float cacthingVolume = SFXManager.instance.cacthingVolume;
        Text[] volumeText = GetComponentsInChildren<Text>();
        //Music Volume:       100 %
        volumeText[2].text = "Music Volume:       " + (int)(backgroundVolume*100) + "%";
        volumeText[5].text = "Effect Volume:       " + (int)(cacthingVolume*100) + "%";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetString ("Music") == "Off") {
			gameObject.GetComponent<AudioSource> ().enabled = false;
		}if (PlayerPrefs.GetString ("Music") == "On") {
			gameObject.GetComponent<AudioSource> ().enabled = true;
		}


	}
}

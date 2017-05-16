using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadMana : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void Load()
	{
		SceneManager.LoadScene ("SampleScene");
	}

	public void LoadTutorial()
	{
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [0] == 0) {
			SceneManager.LoadScene ("Tutorial");
		} else {
			SceneManager.LoadScene ("SampleScene");
		}
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FuturisticLock : MonoBehaviour {
	public GameObject[] StarLevel1;
	public GameObject[] StarLevel2;
	public GameObject[] StarLevel3;
	public GameObject[] StarLevel4;
	public GameObject[] StarLevel5;
	public GameObject[] Locks;
	// Use this for initialization
	void Start () {
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [10] == 0) {

		} else {
			Locks [1].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [11] == 0) {

		} else {
			Locks [2].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [12] == 0) {

		} else {
			Locks [3].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [13] == 0) {

		} else {
			Locks [4].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [10] == 3)
		{
			StarLevel1 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [10] == 2)
		{
			StarLevel1 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [10] == 1)
		{
			StarLevel1 [0].SetActive (true);
		}




		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [11] == 3)
		{
			StarLevel2 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [11] == 2)
		{
			StarLevel2 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [11] == 1)
		{
			StarLevel2 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [12] == 3)
		{
			StarLevel3 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [12] == 2)
		{
			StarLevel3 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [12] == 1)
		{
			StarLevel3 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [13] == 3)
		{
			StarLevel4 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [13] == 2)
		{
			StarLevel4 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [13] == 1)
		{
			StarLevel4 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [14] == 3)
		{
			StarLevel5 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [14] == 2)
		{
			StarLevel5 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [14] == 1)
		{
			StarLevel5 [0].SetActive (true);
		}

	}

	// Update is called once per frame
	void Update () {

	}

	public void Load(string i)
	{
		SceneManager.LoadScene (i);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LockControllerModern : MonoBehaviour {
	public GameObject[] StarLevel1;
	public GameObject[] StarLevel2;
	public GameObject[] StarLevel3;
	public GameObject[] StarLevel4;
	public GameObject[] StarLevel5;
	public GameObject[] Locks;
	// Use this for initialization
	void Start () {
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [5] == 0) {

		} else {
			Locks [1].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [6] == 0) {

		} else {
			Locks [2].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [7] == 0) {

		} else {
			Locks [3].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [8] == 0) {

		} else {
			Locks [4].SetActive (false);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [5] == 3)
		{
			StarLevel1 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [5] == 2)
		{
			StarLevel1 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [5] == 1)
		{
			StarLevel1 [0].SetActive (true);
		}




		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [6] == 3)
		{
			StarLevel2 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [6] == 2)
		{
			StarLevel2 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [6] == 1)
		{
			StarLevel2 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [7] == 3)
		{
			StarLevel3 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [7] == 2)
		{
			StarLevel3 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [7] == 1)
		{
			StarLevel3 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [8] == 3)
		{
			StarLevel4 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [8] == 2)
		{
			StarLevel4 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [8] == 1)
		{
			StarLevel4 [0].SetActive (true);
		}

		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [9] == 3)
		{
			StarLevel5 [2].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [9] == 2)
		{
			StarLevel5 [1].SetActive (true);
		}
		if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [9] == 1)
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

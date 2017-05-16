using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class RandomQuestionGenerator : MonoBehaviour {
	public List<int> Questions = new List<int> ();
	public GameObject[] QuestionHolder;
	public GameObject[] Life;
	public int LifeCount;
	public int Counter;
	public int totalCommands;
	public int Commands;
	public GameObject[] stars;
	public string level;
	public int levels;
	public GameObject RetryPanel;
	public GameObject BlackPanel;
	// Use this for initialization
	void Start()
	{
		Time.timeScale = 1;
		Generate ();
	}
	void OnEnable () {
		
		NextQuestions ();

	}
	
	// Update is called once per frame
	void Update () {
		if (LifeCount < 0) {
			RetryPanel.SetActive (true);
		}
	}

	public void UnlockGame(int i)
	{
		StartCoroutine (Unlock (i));
	}

	IEnumerator Unlock(int i)
	{
		WWWForm form = new WWWForm();
		form.AddField("user_id", GameObject.Find ("DataController").GetComponent<DataController> ().userID);
		form.AddField("level", level);
		form.AddField("value", i);
		UnityWebRequest www = UnityWebRequest.Post("http://code-combat-dev.esy.es/unlock/level", form);
		yield return www.Send();

		if (www.isError)
		{
			Debug.Log(www.error);

		}
		else
		{
			
		}
	}

	public void UpdateGame(int i)
	{
		StartCoroutine (UpdateStars (i));
	}

	IEnumerator UpdateStars(int i)
	{
		WWWForm form = new WWWForm();
		form.AddField("user_id", GameObject.Find ("DataController").GetComponent<DataController> ().userID);
		form.AddField("level", level);
		form.AddField("value", i);
		UnityWebRequest www = UnityWebRequest.Post("http://code-combat-dev.esy.es/update/level", form);
		yield return www.Send();

		if (www.isError)
		{
			Debug.Log(www.error);

		}
		else
		{

		}
	}

	public void EndStage()
	{
		if (LifeCount == 0) 
		{
			stars [0].SetActive (true);
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 0) {
				UnlockGame (1);
				UpdateGame (1);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 1;
			}
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 0) {
				UpdateGame (1);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 1;
			}
		}
		 if (LifeCount == 1) 
		{
			stars [1].SetActive (true);
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 0) {
				UnlockGame (2);
				UpdateGame (2);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 2;
			}
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 1) {
				UpdateGame (2);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 2;
			}
		}
		 if ( LifeCount == 2) 
		{
			
			stars [2].SetActive (true);
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 0) {
				UnlockGame (3);
				UpdateGame (3);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 3;
			}
			if (GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] == 2) {
				UpdateGame (3);
				GameObject.Find ("DataController").GetComponent<DataController> ().levels [levels] = 3;
			}
		}



	}

	private void Generate ()
	{
		Counter += 1;
		int c = Random.Range (0, 29);
		for (int i = 0; i <= 9; i++) {
			c = Random.Range (0, 29);

			foreach (int values in Questions)
				if (values == c) {
					c = Random.Range (0, 29);
				}
			Questions.Add (c);
			//QuestionHolder [Questions [Counter]].SetActive (true);

		}

	}

	public void NextQuestions()
	{
		
		QuestionHolder [Questions [Counter]].SetActive (true);
		BlackPanel.SetActive (true);
	}

	public void CheckAnswer(int i)
	{
		if (i == 1) {
			QuestionHolder [Questions [Counter]].SetActive (false);
			Counter += 1;
			BlackPanel.SetActive (false);
		} else 
		{
			LifeCount -= 1;
			Life [LifeCount + 1].SetActive (false);
		}
	}
}


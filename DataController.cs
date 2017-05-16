using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class DataController : MonoBehaviour {
	public int userID;
	public string FirstName;
	public string jsonString;
	public string jsonString2;
	private JsonData itemData;
	private JsonData itemData2;
	public int[] levels;
	public GameObject[] ErrorHandler;
	public string handler1;
	public string handler2;
	public int TotalScore;
	public string password;
	EventSystem system;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);

		system = EventSystem.current;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			Selectable next = system.currentSelectedGameObject.GetComponent<Selectable> ().FindSelectableOnDown ();

			if (next != null) {

				InputField inputfield = next.GetComponent<InputField> ();
				if (inputfield != null)
					inputfield.OnPointerClick (new PointerEventData (system));  //if it's an input field, also set the text caret

				system.SetSelectedGameObject (next.gameObject, new BaseEventData (system));
			}
		}
		TotalScore = levels [0] + levels [1] + levels [2] + levels [3] + levels [4] + levels [5] + levels [6] + levels [7] + levels [8] + levels [9] + levels [10] + levels [11] + levels [12] + levels [13] + levels [14];
	}
	public void Load()
	{
		SceneManager.LoadScene ("level");
	}

	public void RegisterButton()
	{
		StartCoroutine (Register ());

	}

	public void Quit()
	{
		Application.Quit ();
	}


	IEnumerator Register()
	{

		if (LogInManager.Instance.RegisterPassword.text == LogInManager.Instance.RegisterConfirmPassword.text && LogInManager.Instance.RegisterFirstName.text != "" && LogInManager.Instance.RegisterLastName.text != "") {
			WWWForm form = new WWWForm ();
			form.AddField ("username", LogInManager.Instance.RegisterUsername.text);
			form.AddField ("password", LogInManager.Instance.RegisterPassword.text);
			form.AddField ("first_name", LogInManager.Instance.RegisterFirstName.text);
			form.AddField ("last_name", LogInManager.Instance.RegisterLastName.text);
			UnityWebRequest www = UnityWebRequest.Post ("http://code-combat-dev.esy.es//register", form);
			yield return www.Send ();

			if (www.isError) {
				Debug.Log (www.error);
				ErrorHandler [0].SetActive (true);
			} else {
				Debug.Log (www.downloadHandler.text);
				jsonString2 = www.downloadHandler.text;
				;
				if (handler2 == "True") {
					ErrorHandler [2].SetActive (true);
				}
				if (handler2 == "False") {
					ErrorHandler [0].SetActive (true);
				}
				itemData2 = JsonMapper.ToObject (jsonString2);
				handler2 = itemData2 ["success"].ToString ();
			}
		} else {
			if (LogInManager.Instance.RegisterPassword.text != LogInManager.Instance.RegisterConfirmPassword.text) {
				ErrorHandler [3].SetActive (true);
			} else {
				ErrorHandler [4].SetActive (true);
			}
		}

	}
	public void LoginButton()
	{
		StartCoroutine (LogIn());
	}

	IEnumerator LogIn()
	{
		WWWForm form = new WWWForm();
		form.AddField("username", LogInManager.Instance.LoginUsername.text);
		form.AddField("password", LogInManager.Instance.LoginPassword.text);
		UnityWebRequest www = UnityWebRequest.Post("http://code-combat-dev.esy.es/login", form);
		yield return www.Send();


		if (www.isError)
		{

			jsonString = www.downloadHandler.text;
			jsonString2 = www.downloadHandler.text.ToString();
			itemData = JsonMapper.ToObject (jsonString);
			itemData2 = JsonMapper.ToObject (jsonString2);
		}
		else
		{
			
			Debug.Log(www.downloadHandler.text);

			jsonString = www.downloadHandler.text;
			jsonString2 = www.downloadHandler.text.ToString();
			itemData = JsonMapper.ToObject (jsonString);
			itemData2 = JsonMapper.ToObject (jsonString2);

			userID = int.Parse (itemData ["user_id"].ToString ());
			FirstName = itemData ["first_name"].ToString ();
			handler1 = itemData ["success"].ToString ();
			handler2 = itemData2 ["success"].ToString ();
			password = itemData ["password"].ToString ();
			if (handler1 == "True") {
				SceneManager.LoadScene ("Worlds");
			} else {
				ErrorHandler [1].SetActive (true);
			}

			levels [0] = int.Parse (itemData ["level1"].ToString ());
			levels [1] = int.Parse (itemData ["level2"].ToString ());
			levels [2] = int.Parse (itemData ["level3"].ToString ());
			levels [3] = int.Parse (itemData ["level4"].ToString ());
			levels [4] = int.Parse (itemData ["level5"].ToString ());
			levels [5] = int.Parse (itemData ["level6"].ToString ());
			levels [6] = int.Parse (itemData ["level7"].ToString ());
			levels [7] = int.Parse (itemData ["level8"].ToString ());
			levels [8] = int.Parse (itemData ["level9"].ToString ());
			levels [9] = int.Parse (itemData ["level10"].ToString ());
			levels [10] = int.Parse (itemData ["level11"].ToString ());
			levels [11] = int.Parse (itemData ["level12"].ToString ());
			levels [12] = int.Parse (itemData ["level13"].ToString ());
			levels [13] = int.Parse (itemData ["level14"].ToString ());
			levels [14] = int.Parse (itemData ["level15"].ToString ());
			
			TotalScore = levels [0] + levels [1] + levels [2] + levels [3] + levels [4] + levels [5] + levels [6] + levels [7] + levels [8] + levels [9] + levels [10] + levels [11] + levels [12] + levels [13] + levels [14];

		

		}
	}

	IEnumerator Error()
	{
		yield return new WaitForSeconds (1);
		if (handler1 == "") {
			ErrorHandler [2].SetActive (true);
		}
	}


}

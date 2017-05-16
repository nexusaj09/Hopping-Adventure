using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIROBOT : MonoBehaviour {
	public bool left;
	public bool right;
	public bool up;
	public bool down;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (left) {
			transform.Translate (Vector3.left * Time.deltaTime);
			StartCoroutine (Robot ());
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;
		}
		if (right) {
			transform.Translate (Vector3.right * Time.deltaTime);
			StartCoroutine (Robot2 ());
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		}
		if (up) {
			transform.Translate (Vector3.up * Time.deltaTime);
			StartCoroutine (Robot3 ());

		}
		if (down) {
			transform.Translate (Vector3.down * Time.deltaTime);
			StartCoroutine (Robot4 ());

		}
	}


	IEnumerator Robot()
	{
		left = true;
		yield return new WaitForSeconds (2);
		left = false;
		right = true;
	}
	IEnumerator Robot2()
	{
		right = true;
		yield return new WaitForSeconds (2);
		right = false;
		left = true;
	}
	IEnumerator Robot3()
	{
		up = true;
		yield return new WaitForSeconds (2);
		up = false;
		down = true;
	}
	IEnumerator Robot4()
	{
		down = true;
		yield return new WaitForSeconds (2);
		down = false;
		up = true;
	}
}

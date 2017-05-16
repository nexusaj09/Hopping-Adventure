using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour {
	public GameObject DeadPanel;
	void OnTriggerEnter2D(Collider2D other)
	{
		DeadPanel.SetActive (true);
	}
}

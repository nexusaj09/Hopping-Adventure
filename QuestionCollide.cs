using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionCollide : MonoBehaviour {
	public GameObject Question;
	public RandomQuestionGenerator QG;

	void OnTriggerEnter2D(Collider2D other)
	{
		Question.SetActive (true);
		QG.NextQuestions ();
		Destroy (gameObject);
	}
}

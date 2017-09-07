using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	int scoreInitial = 0;

	void Start () {
		DrawScore ();
	}

	void Update (){
		DrawScore ();
	}

	void DrawScore (){
		scoreText.text = scoreInitial.ToString();
	}

	public void IncrementAndDrawScore(){
		scoreInitial += 5;
		DrawScore ();
	}



}

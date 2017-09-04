using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	public float velocity;
	GameObject[] gameOverObjects;

	void Start () {
		gameOverObjects = GameObject.FindGameObjectsWithTag ("gameOver");

		foreach (GameObject g in gameOverObjects) {
			g.SetActive (false);
		}
	}

	void Update () {
		Vector3 dir = new Vector3(Input.acceleration.x * velocity, 0.0f, 0.0f);
		transform.position += dir;	
	}

	void OnCollisionEnter2D(Collision2D other){
		foreach (GameObject g in gameOverObjects) {
			g.SetActive (true);
		}
		Time.timeScale = 0;
	}

}

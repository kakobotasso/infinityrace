using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

	public float velocity;
	public float leftLimit;
	public float rightLimit;
	GameObject[] gameOverObjects;
	bool playing;

	void Start () {
		gameOverObjects = GameObject.FindGameObjectsWithTag ("gameOver");
		playing = true;

		foreach (GameObject g in gameOverObjects) {
			g.SetActive (false);
		}
	}

	void Update () {
		Vector3 dir = new Vector3(Input.acceleration.x * velocity, 0.0f, 0.0f);
		Vector3 newPosition = transform.position + dir;

		if (playing) {
			if (newPosition.x > leftLimit && newPosition.x < rightLimit) {
				transform.position = newPosition;
			} else {
				if (newPosition.x > leftLimit) {
					newPosition.x = rightLimit;
				} else if (newPosition.x < rightLimit) {
					newPosition.x = leftLimit;
				}
				transform.position = newPosition;
			}
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "enemy") {
			foreach (GameObject g in gameOverObjects) {
				g.SetActive (true);
			}
			playing = false;
			Time.timeScale = 0;	
		}
	}
}

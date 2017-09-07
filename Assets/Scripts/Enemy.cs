using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float velocity;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * velocity * Time.deltaTime);

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		if (screenPosition.x <= -5.0f){
			Destroy (gameObject);
		}

		if (screenPosition.y <= -Screen.height){
			// UPDATE SCORE
			// INCREMENT VELOCITY
			Destroy (gameObject);
		}
	}
}

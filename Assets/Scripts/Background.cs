using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	public float yLimit;
	public float yReturn;
	public float velocity;

	void Update () {
		transform.Translate (Vector2.down * velocity * Time.deltaTime);

		if (transform.position.y < yLimit) {
			transform.position = new Vector3 (0.0f, yReturn, 0.0f);	
		} 
	}
}

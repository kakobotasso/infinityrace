﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float velocity;
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * velocity * Time.deltaTime);
	}
}

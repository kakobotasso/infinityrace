using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyGenerator : MonoBehaviour {

	public GameObject enemy;
	public float line01;
	public float line02;
	public float line03;
	public float line04;

	bool line01Used = false;
	bool line02Used = false;
	bool line03Used = false;
	bool line04Used = false;

	bool running = true;

	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		InvokeRepeating ("CreateEnemy", 0.5f, 3.5f);
	}

	void CreateEnemy() {
		if (running) {
			int numberEnemies = UnityEngine.Random.Range (1, 4);

			for (int i = 0; i < numberEnemies; i++) {
				enemy.transform.position = new Vector3(RandomLine(), 7.0f, 0.0f) ;
				Instantiate (enemy);
			}

		}

		line01Used = false;
		line02Used = false;
		line03Used = false;
		line04Used = false;
	}

	float RandomLine(){
		int actualRandom = UnityEngine.Random.Range (0, 5);

		switch (actualRandom) {
		case 1:
			if (!line01Used) {
				line01Used = true;
				return line01;
			}
			break;
		case 2:
			if (!line02Used) {
				line02Used = true;
				return line02;
			}
			break;
		case 3:
			if (!line03Used) {
				line03Used = true;
				return line03;
			}
			break;
		case 4:
			if (!line04Used) {
				line04Used = true;
				return line04;
			}
			break;
		}

		return -5.0f;
	}

}

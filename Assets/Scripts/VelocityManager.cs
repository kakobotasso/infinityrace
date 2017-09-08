using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityManager : MonoBehaviour {

	public float enemyVelocity;
	public float backgroundVelocity;

	public void IncreaseVelocity (){
		Time.timeScale += 0.15f;
	}
}

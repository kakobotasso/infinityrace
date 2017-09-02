using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void GoToGame(){
		SceneManager.LoadScene ("game");
	}
}

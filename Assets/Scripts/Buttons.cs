using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

	public Button mainMenu;
	public Button playAgain;

	void Start () {
		Time.timeScale = 1;
		if (playAgain != null) {
			playAgain.onClick.AddListener (GoToGame);
		}

		if (mainMenu != null) {
			mainMenu.onClick.AddListener (GoToMenu);
		}
			
	}

	public void GoToGame () {
		SceneManager.LoadScene ("game");
	}

	public void GoToMenu () {
		SceneManager.LoadScene ("menu");
	}
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

	public Button mainMenu;
	public Button playAgain;
	public Button resumeGame;
	public Button mainMenuPaused;
	public Button pauseGame;
	GameObject[] pauseObjects;

	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag ("pause");
		pausedItensActive (false);

		if (playAgain != null) {
			playAgain.onClick.AddListener (GoToGame);
		}

		if (mainMenu != null) {
			mainMenu.onClick.AddListener (GoToMenu);
		}

		if (resumeGame != null) {
			resumeGame.onClick.AddListener (ResumeGame);
		}

		if (mainMenuPaused != null) {
			mainMenuPaused.onClick.AddListener (GoToMenu);
		}

		if (pauseGame != null) {
			pauseGame.onClick.AddListener (PauseGame);
		}
			
	}

	public void GoToGame () {
		SceneManager.LoadScene ("game");
	}

	public void GoToMenu () {
		SceneManager.LoadScene ("menu");
	}

	public void PauseGame () {
		Time.timeScale = 0;
		pausedItensActive (true);
		pauseGame.gameObject.SetActive (false);
	}

	public void ResumeGame () {
		Time.timeScale = 1;
		pausedItensActive (false);
		pauseGame.gameObject.SetActive (true);
	}

	void pausedItensActive(bool status) {
		foreach (GameObject g in pauseObjects) {
			g.SetActive (status);
		}
	}
}

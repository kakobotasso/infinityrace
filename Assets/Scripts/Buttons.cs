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
	public Text gamePaused;
	GameObject[] pauseObjects;


	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag ("pauseItem");

		if (playAgain != null) {
			playAgain.onClick.AddListener (GoToGame);
		}

		if (mainMenu != null) {
			mainMenu.onClick.AddListener (GoToMenu);
		}

		if (gamePaused != null) {
			gamePaused.gameObject.SetActive (false);
		}

		if (resumeGame != null) {
			resumeGame.onClick.AddListener (ResumeGame);
			resumeGame.gameObject.SetActive(false);
		}

		if (mainMenuPaused != null) {
			mainMenuPaused.onClick.AddListener (GoToMenu);
			resumeGame.gameObject.SetActive(false);
			mainMenuPaused.gameObject.SetActive(false);
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

		gamePaused.gameObject.SetActive (true);
		resumeGame.gameObject.SetActive(true);
		mainMenuPaused.gameObject.SetActive(true);

		pauseGame.gameObject.SetActive (false);
	}

	public void ResumeGame () {
		Time.timeScale = 1;

		gamePaused.gameObject.SetActive (false);
		resumeGame.gameObject.SetActive(false);
		mainMenuPaused.gameObject.SetActive(false);

		pauseGame.gameObject.SetActive (true);
	}
}

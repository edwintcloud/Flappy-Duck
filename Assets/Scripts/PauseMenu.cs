using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public void pauseGame() {
		Time.timeScale = 0;
	}

	public void resumeGame() {
		Time.timeScale = 1;
	}

	public void restartGame() {
		Application.LoadLevel(Application.loadedLevel);
		Time.timeScale = 1;
	}

	public void quitGame() {
		Application.Quit ();
	}
}

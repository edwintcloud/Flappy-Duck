using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;
	private int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != null) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0))) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BirdScored() {
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString ();
	}

	public void BirdDied() {
		gameOverText.SetActive (true);
		gameOver = true;
	}
}

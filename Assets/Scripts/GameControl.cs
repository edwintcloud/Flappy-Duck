using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
    public Text levelText;
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
        if (score == 2)
        {
            ColumnPool.spawnRate = 3.5f;
            scrollSpeed += 1f;
            levelText.text = "Level 2";
        }
        if (score == 6)
        {
            ColumnPool.spawnRate = 3.25f;
            scrollSpeed += 1f;
            levelText.text = "Level 3";
        }
        if (score == 10)
        {
            ColumnPool.spawnRate = 3f;
            scrollSpeed += 1f;
            levelText.text = "Level 4";
        }
        if (score == 15)
        {
            ColumnPool.spawnRate = 2.75f;
            scrollSpeed += 1f;
            levelText.text = "Level 5";
        }
        if (score == 22)
        {
            ColumnPool.spawnRate = 2.5f;
            scrollSpeed += 1f;
            levelText.text = "Level 6";
        }
        if (score == 31)
        {
            ColumnPool.spawnRate = 2.25f;
            scrollSpeed += 1f;
            levelText.text = "Level 7";
        }
        if (score == 40)
        {
            ColumnPool.spawnRate = 2f;
            scrollSpeed += 1f;
            levelText.text = "Level 8 - Mastery";
        }
    }

	public void BirdDied() {
		gameOverText.SetActive (true);
		gameOver = true;
	}
}

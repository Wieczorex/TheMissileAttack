using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
	public static int iloscPozostalychZyc = 3;
	public Text zyciaText;

	public int highScore;
	public static int highestScore;

	public Text scoreText;
	public static int score;

	public static float levelProgress;

	public static bool isGameOver = false;

	public static bool isPaused = false;
	public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
		LoadPlayer();
		score = 0;
		isGameOver = false;
		isPaused = false;
		iloscPozostalychZyc = 3;
    }

    // Update is called once per frame
    void Update()
    {

		if (!isGameOver && !isPaused)
		{
			Time.timeScale = 1f;
			levelProgress = Time.deltaTime * 1.5f;

			scoreText.text = score.ToString();

			zyciaText.text = iloscPozostalychZyc.ToString();
		}
		else if (isGameOver)
		{
			GameOver();
		}
		else if (isPaused)
		{
			PauseGame();
		}
		if (iloscPozostalychZyc <= 0)
		{
			isGameOver = true;
		}
    }
	//Pause Menu Things
	public void PauseGame()
	{
		Time.timeScale = 0f;
		pauseMenu.SetActive(true);
	}

	public void ClickToPauseGame()
	{
		isPaused = true;
	}

	//Game Over Things
	public void GameOver()
	{
		CheckTheHighScore();
		Time.timeScale = 0f;
	}

	public void CheckTheHighScore()
	{
		if (score > highScore)
		{
			highScore = score;
		}
		highestScore = highScore;
		SavePlayer();
	}

	//Save and Load System
	public void SavePlayer()
	{
		SaveSystem.SavePlayer(this);
	}
	public void LoadPlayer()
	{
		PlayerData data = SaveSystem.LoadPlayer();
		highScore = data.highScore;
	}
}

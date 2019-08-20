using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
	public GameObject gameOverPanel;

	public Text highScoreText;
	public Text actualScoreText;

	void Update()
	{
		if (GameControl.isGameOver)
		{
			ShowGameOverPanel();
		}
	}

	void ShowGameOverPanel()
	{
		gameOverPanel.SetActive(true);
		highScoreText.text = "HIGH SCORE: " + GameControl.highestScore;
		actualScoreText.text = "YOUR FINAL SCORE: " + GameControl.score;
	}

	public void TryAgain()
	{
		GameControl.isGameOver = false;
		HideGameOverPanel();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void GoToMainMenu()
	{
		SceneManager.LoadScene(0);
	}

	void HideGameOverPanel()
	{
		gameOverPanel.SetActive(false);
	}
}

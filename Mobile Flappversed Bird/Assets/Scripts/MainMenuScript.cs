using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
	public GameObject sceneTransitionObject;

	public static bool isHelpReaded = false;
	private bool startGry = false;

    void Start()
    {
		Time.timeScale = 1f;
		startGry = false;
		isHelpReaded = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (startGry)
		{
			sceneTransitionObject.SetActive(true);
		}
		if (isHelpReaded)
		{
			if (Input.touchCount > 0)
			{
				SceneManager.LoadScene(1);
			}
		}
    }

	public void StartGame()
	{
		startGry = true;
		StartCoroutine("Czas");
	}
	IEnumerator Czas()
	{
		yield return new WaitForSeconds(6);
		isHelpReaded = true;
	}
}

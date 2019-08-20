using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
	public Text bottomText;
	
	public string[] teksty;
	public string coWpisac;

	public int losowanieTekstu;
	public int ktoryZnak = 0;

	void OnEnable()
	{
		bottomText.text = "";
		ktoryZnak = 0;
		losowanieTekstu = Random.Range(0, teksty.Length);
		coWpisac = teksty[losowanieTekstu];
		WriteText();
	}

	public void WriteText()
	{
		if (ktoryZnak < coWpisac.Length)
		{
			bottomText.text = bottomText.text + coWpisac[ktoryZnak].ToString();
			ktoryZnak = ktoryZnak + 1;
			StartCoroutine("Czas");
		}
	}

	public void ReturnToGame()
	{
		GameControl.isPaused = false;
		this.gameObject.SetActive(false);
	}

	IEnumerator Czas()
	{

		yield return new WaitForSecondsRealtime(0.1f);
		WriteText();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTransitionScript : MonoBehaviour
{
	public Text loadingTextObject;

	public string loadingText;

	private int loadingLoop;
    // Start is called before the first frame update
    void Start()
    {
		loadingText = "Loading";
		loadingLoop = 0;
		Loading();
    }

    // Update is called once per frame
    void Update()
    {
		loadingTextObject.text = loadingText;
    }

	public void Loading()
	{
		if (MainMenuScript.isHelpReaded == false)
		{
			if (loadingLoop <= 2)
			{
				loadingText = loadingText + ".";
				loadingLoop = loadingLoop + 1;
			}
			StartCoroutine("Czas");
		}
		else if (MainMenuScript.isHelpReaded == true)
		{
			loadingText = "Tap Anywhere To Start";
		}
	}

	IEnumerator Czas()
	{

		yield return new WaitForSeconds(1f);
		if (loadingLoop == 3)
		{
			loadingLoop = 0;
			loadingText = "Loading";
		}
		Loading();
	}
}

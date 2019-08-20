using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyTouchesNetScript : MonoBehaviour
{
	private bool blokadaDotkniecia = false;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (!blokadaDotkniecia)
		{
			if (col.tag == "Siatka")
			{
				ZlapanyMotyl();
			}
			else if (col.tag == "LiniaNiszczaca")
			{
				ZniszczonyMotyl();
			}
		}
		blokadaDotkniecia = true;
	}

	public void ZlapanyMotyl()
	{
			if (this.tag == "MotylCoin")
			{
				transform.DetachChildren();
			}
			GameControl.score = GameControl.score + 1;
			Destroy(gameObject);
	}

	public void ZniszczonyMotyl()
	{
		Destroy(gameObject);
	}

	void OnTriggerExit2D(Collider2D col)
	{
		blokadaDotkniecia = false;
	}
}

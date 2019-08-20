using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetTouchingScript : MonoBehaviour
{
	private bool moveUp = false;
	private bool moveDown = false;

	private Transform tr;

	public float szybkoscPodnoszenia;
	// Start is called before the first frame update
	void Start()
	{
		tr = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{

		if (transform.position.y <= 4.25f)
		{
			if (moveUp && !moveDown)
			{
				PodnoszenieSiatki();
			}
		}
		else { transform.position = new Vector3(tr.position.x, 4.25f, tr.position.z); }
		if (transform.position.y >= -1.3f)
		{
			if (moveDown && !moveUp)
			{
				ObnizanieSiatki();
			}
		}
		else { tr.position = new Vector3(tr.position.x, -1.3f, tr.position.z); }


		if (szybkoscPodnoszenia <= 3)
		{
			szybkoscPodnoszenia = szybkoscPodnoszenia + GameControl.levelProgress / 200;
		}
	}
	
	public void PodnoszenieSiatki()
	{
		tr.Translate(Vector3.up * szybkoscPodnoszenia * Time.deltaTime);
	}

	public void ObnizanieSiatki()
	{
		tr.Translate(-Vector3.up * szybkoscPodnoszenia * Time.deltaTime);
	}

	public void ButtonMoveUp()
	{
		moveDown = false;
		moveUp = true;
	}
	public void ButtonMoveDown()
	{
		moveUp = false;
		moveDown = true;
	}

	public void ButtonUpStopHolding()
	{
		moveUp = false;
	}
	public void ButtonDownStopHolding()
	{
		moveDown = false;
	}
}

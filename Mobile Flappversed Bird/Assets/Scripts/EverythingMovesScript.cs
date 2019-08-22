using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverythingMovesScript : MonoBehaviour
{
	private Transform tr;

	private float predkoscRuszaniaSie = 3;

    // Start is called before the first frame update
    void Start()
    {
		predkoscRuszaniaSie = 3;
		tr = GetComponent<Transform>();
    }

	// Update is called once per frame
	void Update()
	{
		tr.Translate(Vector3.left * predkoscRuszaniaSie * Time.deltaTime);
		if (GameControl.score >= 50)
		{
			predkoscRuszaniaSie = 3.5f;
		}
		if (GameControl.score >= 200)
		{
			predkoscRuszaniaSie = 4;
		}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTouchedObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if (transform.tag != "Siatka" )
		{
			GameControl.iloscPozostalychZyc = GameControl.iloscPozostalychZyc - 1;
			Destroy(col.gameObject);
		}
		else
		{
			if (col.tag == "Obstacle")
			{
				Destroy(col.gameObject);
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EverythingMovesScript : MonoBehaviour
{
	private Transform tr;

	public float predkoscRuszaniaSie;

    // Start is called before the first frame update
    void Start()
    {
		tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		tr.Translate(Vector3.left * predkoscRuszaniaSie * Time.deltaTime);
    }
}

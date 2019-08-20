using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextRotateScript : MonoBehaviour
{ 

	private GameObject textObject;
    // Start is called before the first frame update
    void Start()
    {
		textObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.PingPong(Time.time * 30, 30.0f)-15);
		float pong = Mathf.PingPong(Time.time/3, .2f)+1f;
		textObject.GetComponent<RectTransform>().localScale = new Vector3(pong, pong, 1);
    }
}

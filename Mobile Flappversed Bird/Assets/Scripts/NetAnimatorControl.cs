using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetAnimatorControl : MonoBehaviour
{
	public AudioClip dzwiekWybuchu; 
	private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
		animator = GetComponent<Animator>();
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Pocisk" || col.tag == "Obstacle")
		{
			AudioSource.PlayClipAtPoint(dzwiekWybuchu, transform.position);
			animator.ResetTrigger("Hit");
			animator.SetTrigger("Hit");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchMoving : MonoBehaviour
{
	private Animator animator;

	public GameObject tarczaGorna;
	public GameObject tarczaDolna;

	public bool blokadaSpawnuTarczy = false;

	private Rigidbody2D rb;
	public Vector2 jumpForce = new Vector2(0, 5); 

	void Start()
	{
		animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void Update()
	{
		/*int i = 0;
		//loop over every touch found
		while (i < Input.touchCount)
		{
			if (!blokadaSpawnuTarczy)
			{
				if (Input.GetTouch(i).position.x > Screen.width / 1.3f)
				{
					blokadaSpawnuTarczy = true;
					if (Input.GetTouch(i).position.y > Screen.height / 2)
					{
						AktywowanieGornejTarczy();
					}

					if (Input.GetTouch(i).position.y < Screen.height / 2)
					{
						AktywowanieDolnejTarczy();
					}
				}
			}
			++i;
		}*/
	}

	public void AktywowanieGornejTarczy()
	{
		if (!blokadaSpawnuTarczy)
		{
			tarczaGorna.SetActive(true);
			StartCoroutine("Czas", "tarczaGorna");
		}
	}

	public void AktywowanieDolnejTarczy()
	{
		if (!blokadaSpawnuTarczy)
		{
			tarczaDolna.SetActive(true);
			StartCoroutine("Czas", "tarczaDolna");
		}
	}

	IEnumerator Czas(string coBlokowac)
	{
		blokadaSpawnuTarczy = true;
		animator.ResetTrigger("Hit");
		animator.SetTrigger("Hit");
		yield return new WaitForSeconds(0.8f);
		if (coBlokowac == "tarczaGorna")
		{
			tarczaGorna.SetActive(false);
		}
		else if (coBlokowac == "tarczaDolna")
		{
			tarczaDolna.SetActive(false);
		}
		blokadaSpawnuTarczy = false;
		animator.ResetTrigger("Hit");
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.tag == "Obstacle")
		{
			GameControl.isGameOver = true;
		}
	}
}

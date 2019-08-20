using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflySpawnerScript : MonoBehaviour
{

	public GameObject angryMissilePrefab;
	private Vector3 missileStartPosition;

	public float timeTillNextSpawn;
	public float timePassed;
	// Start is called before the first frame update
	void Start()
    {
		SpawnButterfly();
    }

    // Update is called once per frame
    void Update()
    {
		timePassed = timePassed + Time.deltaTime;
		if (timePassed >= timeTillNextSpawn)
		{
			SpawnButterfly();
		}
    }

	public void SpawnButterfly()
	{

		float pozycjaY = Random.Range(-1.20f, 3.65f);
		missileStartPosition = new Vector3(15, pozycjaY, 0);

		GameObject motyl = Instantiate(angryMissilePrefab, missileStartPosition, Quaternion.identity);
		motyl.tag = "Pocisk";
		
		timePassed = 0;
		
		if (timeTillNextSpawn >= 1.3f)
		{
			timeTillNextSpawn = timeTillNextSpawn - GameControl.levelProgress;
		}
	}
}

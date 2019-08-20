using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
	public GameObject greenMissilePrefab;
	public GameObject blueMissilePrefab;
	private GameObject missilePrefab;

	private Vector3 obstacleStartPosition;
	

	public float timeTillNextSpawn = 5;
	public float timePassed;

	private bool isLayingBlock;

	// Update is called once per frame
	void Update()
	{
		timePassed = timePassed + Time.deltaTime;
		if (timePassed >= timeTillNextSpawn)
		{
			SpawnObstacle();
		}
	}

	public void SpawnObstacle()
	{
		isLayingBlock = (Random.value > 0.5f);
		if (isLayingBlock)
		{
			obstacleStartPosition = new Vector3(15, -4.528f, 0);
			missilePrefab = greenMissilePrefab;
		}
		else
		{
			obstacleStartPosition = new Vector3(15, -3.558f, 0);
			missilePrefab = blueMissilePrefab;
		}
		GameObject obstacle = Instantiate(missilePrefab, obstacleStartPosition, Quaternion.identity);
		obstacle.transform.tag = "Obstacle";
		timePassed = 0;

		if (timeTillNextSpawn >= 1.8f)
		{
			timeTillNextSpawn = timeTillNextSpawn - GameControl.levelProgress * 2;
		}
	}
}

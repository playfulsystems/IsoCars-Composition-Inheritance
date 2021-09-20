using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject carPrefab;
	public GameObject pelletPrefab;
	float spawnTime = 0;

	void Update()
	{
		if (spawnTime < 0)
		{
			CreateNewObject();
			spawnTime = Random.Range(1.5f, 3f);
		}

		spawnTime -= Time.deltaTime;
	}

	void CreateNewObject()
	{
		int whichObject = Random.Range(0, 4);

		if (whichObject == 0)
		{
			GameObject newPellet = (GameObject)Instantiate(pelletPrefab);
			newPellet.transform.position = transform.position + new Vector3(0, 0.5f, 0);
			newPellet.transform.rotation = transform.rotation;
		}
		else
		{
			GameObject newCar = (GameObject)Instantiate(carPrefab);
			newCar.transform.position = transform.position;
			newCar.transform.rotation = transform.rotation;
		}
	}
}

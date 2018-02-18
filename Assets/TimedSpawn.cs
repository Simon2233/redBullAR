using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour {

	public GameObject spawnee;
	public bool stopSpawning = false;
	public float spawnTime;
	public float spawnDelay;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);
	}

	public void SpawnObject() {
		Vector3 position = new Vector3(Random.Range (-5.0f, 5.0f), -0.3f, Random.Range(-5.0f, 5.0f));
		Instantiate(spawnee, position, transform.rotation);

		if (stopSpawning) {
			CancelInvoke ("SpawnObject");
		}
	}


}
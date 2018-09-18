//this script is for spawning the apples, it must be attached to an empy object called AppleSpawn, or the prefab

using UnityEngine;
using System.Collections;

public class spawnEvenMore : MonoBehaviour {

	public GameObject spawnObject;
	public Object clone;

	public float xRange = 1.0f;
	public float yRange = 1.0f;
	public float spawnTime = 3.0f;
	public float lifetime;

	void Start()
	{
		InvokeRepeating("SpawnWall", 2, spawnTime);
	}

	void SpawnWall() {
		clone = Instantiate (spawnObject, GameObject.Find("AppleSpawn3").transform.position, GameObject.Find("AppleSpawn3").transform.rotation);
		Destroy (clone, lifetime);
	}

	void Update () {
		
	}
		
}

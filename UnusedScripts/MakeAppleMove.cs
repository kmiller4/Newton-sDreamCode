using UnityEngine;
using System.Collections;

public class MakeAppleMove : MonoBehaviour {

	//this is an older script used to try moving an apple with a fixed transform and destroy it when hitting a wall, it didn't work

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * Time.deltaTime;
	}
	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "wall") {
			//Destroy(col.gameObject);
		}
	}
}
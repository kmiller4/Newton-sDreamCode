using UnityEngine;
using System.Collections;

public class moveUp : MonoBehaviour {
	
	//this script was from NurFace and used to move the box up to the sky, it attaches to the box

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void moveBoxUp() {
		transform.position += new Vector3 (0f, 1f, 0f);
	}
}

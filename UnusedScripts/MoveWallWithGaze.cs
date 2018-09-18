using UnityEngine;
using System.Collections;

public class MoveWallWithGaze : MonoBehaviour {

	//this script is to make a wall start moving when you click it, the wall follows one position axis of your movement until you release
	public GameObject cardboardCamera;
	public GameObject otherThing;
	public float rotation; //this will be the rotation of the head
	public bool toggle = false;

	float delayTimer = 0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		delayTimer += Time.deltaTime;
		rotation = cardboardCamera.transform.localEulerAngles.y;//this is the current y value in degrees
		   //print(delayTimer);

		while (toggle == true && delayTimer > 0.1) { // && delay != true)
			delayTimer = 0;
			moveTheWall ();
		}

	}

	//need to move the y position of the wall based on the y rotation of the camera
	//when you click the switch, it toggles whether or not you can move the wall
	public void enableMovingWall() {
		toggle = !toggle;
	}

	public void moveTheWall() {
		otherThing.transform.position = new Vector3 (otherThing.transform.position.x, 4 + -1 * ((rotation - 180) * Mathf.Deg2Rad), otherThing.transform.position.z);
	}

}
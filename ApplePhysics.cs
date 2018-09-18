//HOW ABOUT NOW?????

//IS THE TORTOISE SVN WORKING?????

//this is how the apple moves, attach to apple_final prefab

using UnityEngine;
using System.Collections;

public class ApplePhysics : MonoBehaviour {
	public Rigidbody rb;
	public Vector3 v = new Vector3();
	//public float direction;
	public AudioClip weHitPlatformy;

	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.velocity = v;
	}
	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "platformy") {
			//Destroy(col.gameObject);
			//rb.velocity = new Vector3(0, 3, 0);
			//transform.position += Vector3.forward * Time.deltaTime;
			//rb.velocity = 2 * (col.gameObject.transform.up) - rb.position;
			//rb.velocity += Vector3.forward * Time.deltaTime;
			//rb.velocity = direction * col.gameObject.transform.forward; WTF IS PHYSICS???????????
			//Debug.Log ("wtf is physics");

			AudioSource.PlayClipAtPoint (weHitPlatformy, this.transform.position);
		}
	}
}
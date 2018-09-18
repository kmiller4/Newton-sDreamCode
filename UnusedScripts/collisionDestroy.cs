//this is an old script used to destroy a wall on collision, now used in apple physics

using UnityEngine;
using System.Collections;

public class collisionDestroy : MonoBehaviour {
	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "wall") {
			//Destroy(col.gameObject);
		}
	}

}
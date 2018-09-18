using UnityEngine;
using System.Collections;

public class destroywall : MonoBehaviour {

	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name == "apple") {
			//Destroy(col.gameObject);
		}
	}
}
//this is for destroying the UI text after level intros, attach to the text under head > main camera

using UnityEngine;
using System.Collections;

public class DestroyText : MonoBehaviour {

	public float lifetime;

	void Update() {
		Destroy (gameObject, lifetime);
	}
		
}

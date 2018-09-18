//this tells the game to load the next level, attach to the apple_final prefab

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelEndGoal : MonoBehaviour {
	
	public int nextLevelIndex;
	public AudioClip transitionSound;
	public Rigidbody rb;
	public Vector3 v = new Vector3();
	public ParticleSystem party;
	public ParticleSystem party2;
	public ParticleSystem party3;

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "LevelEndGoal") {
			rb.velocity = new Vector3 (0, 0, 0);
			party.startColor = Color.yellow;
			party2.startColor = Color.yellow;
			party3.startColor = Color.yellow;
			party.startSpeed = 1.0f;
			party2.startSpeed = 1.0f;
			party3.startSpeed = 1.0f;
			AudioSource.PlayClipAtPoint (transitionSound, this.transform.position);
			Debug.Log ("we made it to step 1");
			Invoke ("holdOn", 1.0f);
		}
	}

	void holdOn() {
		Debug.Log ("we made it to step 2");
		SceneManager.LoadScene (nextLevelIndex);
	}
}

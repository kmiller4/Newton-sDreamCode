//this script is for moving your camera to wherever the eyeball is by clicking it, this script attaches to the eyeball prefab and calls the cardboard camera

using UnityEngine;
using System.Collections;

public class MoveCameraHere : MonoBehaviour {

	//NEW UPDATE: OCT 30 2016 when loading a scene, the first tag should start out as regular eyes
	//NOW on June/24/2017 this script didn't work because the cardboard camera was set to GvRMain, when it needed to be switched a parent object, I made one called CameraParent
	public static string currentTag = "regularEyes";
	public Transform cardboardCamera;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	public void moveCamera (Collider col) {
//		currentTag = col.tag;
//		cardboardCamera.transform.position = this.transform.position;
//		cardboardCamera.transform.rotation = this.transform.rotation;
//	}

	//NOW on June/24/2017, maybe the real reason this didn't work was because the Collider col input was breaking it
	public void moveCamera () {
		//currentTag = col.tag;
		cardboardCamera.transform.position = this.transform.position;
		cardboardCamera.transform.rotation = this.transform.rotation;
	}

	//public Animation anim;
	//IEnumerator Start() {
		//anim = GetComponent<Animation>();
		//anim.Play(anim.clip.);
		//yield return new WaitForSeconds(anim.clip.length);
	//}
}
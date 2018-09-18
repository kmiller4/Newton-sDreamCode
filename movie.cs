//this script plays the intro cutscene and then changes to the first level after it is done
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent (typeof(AudioSource))]

public class movie : MonoBehaviour {
	public int mainScreen;

//	public MovieTexture movieclips;
//	private MeshRenderer meshRenderer;
//
//	void Start(){
//		meshRenderer = GetComponent<MeshRenderer>();
//		meshRenderer.material.mainTexture = movieclips;
//
//		AudioSource audio = GetComponent<AudioSource>();
//		audio.Play();
//
//		movieclips.Play ();
//	}
//
//	void Update(){
//		if ( movieclips.isPlaying == false ) {
//			SceneManager.LoadScene(1);
//		}
//	}

//	void Start () { StartCoroutine(PlayMovie()); }
//
//	protected IEnumerator PlayMovie(){
//
//		Handheld.PlayFullScreenMovie("newtdream-anim_01.ogv", Color.blue, FullScreenMovieControlMode.Hidden);
//
//		yield return new WaitForSeconds(25.0f);
//
//		SceneManager.LoadScene(1);
//	}

	void Start(){
		Handheld.PlayFullScreenMovie ( "intro-animation-with-sound-yeye.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		SceneManager.LoadScene(mainScreen);
	}

}
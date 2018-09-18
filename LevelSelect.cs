using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {
	public string nextLevel; 

	public void goToLevel () {
		SceneManager.LoadScene(nextLevel);

	}

}
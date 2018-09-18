using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour {
	
	public void reloadthisScene() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}


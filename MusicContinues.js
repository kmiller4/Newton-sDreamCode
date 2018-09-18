//this keeps the music track playing from level to level, attach to the NewtonsOST song or any other music

#pragma strict

import UnityEngine.SceneManagement;

 private static var instance : MusicContinues;
 public static function GetInstance() : MusicContinues { 
     return instance;
 }
  
 function Awake() {
     if (instance != null && instance != this) {
         Destroy(this.gameObject);
         return;
     } else {
         instance = this;
     }
     DontDestroyOnLoad(this.gameObject);
 }

 function Update ()
{
    if (SceneManager.GetActiveScene().name == "credits") {
     	 Destroy(this.gameObject);
     }
}
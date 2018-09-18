//this is used to make the wall movable by parenting it to the camera and toggling that, attach to the MovableWall prefab
//you have to parent the head to the transform manually through cardboard main > head UPDATE: GvrMain

using UnityEngine;
using System.Collections;

public class ParentWall : MonoBehaviour
{
	public GameObject head;
	bool isParented = false;
	public AudioClip platformSelect;
	public AudioClip platformDeselect;

	//this in this case refers to the MovableWall
	//Invoked when pointerDown triggers (cardboard button)

	public void Parent(Transform head)
	{
		/*if (isParented == false && this.tag == MoveCameraHere.currentTag) {
			//Sets "newParent" as the new parent of the wall, NEW UPDATE: OCT 30 2016 And Match Eye Tags, Eye tags aren't working in Android
			this.transform.SetParent (head);
			isParented = true;
			AudioSource.PlayClipAtPoint (platformSelect, this.transform.position);
		}*/
		if (isParented == false) {
			//Sets "newParent" as the new parent of the wall, NEW UPDATE: OCT 30 2016 And Match Eye Tags, 
			//NOW in 06/24/2017 Eye tags aren't working after building for Android, skipping the last two levels anyway
			//the other colors are only used in level 7, not even 6. The New Year's build included at least one level that included 3 colors, but it wasn't built properly. 
			this.transform.SetParent (head);
			isParented = true;
			AudioSource.PlayClipAtPoint (platformSelect, this.transform.position);
		}
		else {
			this.transform.SetParent (null);
			isParented = false;
			AudioSource.PlayClipAtPoint (platformDeselect, this.transform.position);
		}
	}
}
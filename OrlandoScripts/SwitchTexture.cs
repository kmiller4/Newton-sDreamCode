using UnityEngine;
using System.Collections;
//For switching platformy's texture more consistently

public class SwitchTexture : MonoBehaviour {

	public bool isPlatformySelected = false;
	public Material hoverPlatformy;

	public void switchMaterial (Material newMaterial){
		Renderer rend = GetComponent<Renderer>();

		//On 6/24/2017 I thought this wasn't working because of OnPointerDown not working, but it actually was, just ParentWall wasn't working
		if (newMaterial.ToString().Contains("active") && isPlatformySelected == false) {
			rend.material = newMaterial;
			isPlatformySelected = true;

		}else if (newMaterial.ToString().Contains("active") && isPlatformySelected == true) {
			rend.material = hoverPlatformy;
			isPlatformySelected = false;

		} else if (newMaterial.ToString().Contains("hover") && isPlatformySelected == false) {
			rend.material = newMaterial;

		} else if (newMaterial.ToString().Contains("rest") && isPlatformySelected == false) {
			rend.material = newMaterial;
		}
	}
}

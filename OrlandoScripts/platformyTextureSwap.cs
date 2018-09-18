using UnityEngine;
using UnityEngine.EventSystems;
//THIS ONE DIDN'T WORK, IGNORE IT

public class platformyTextureSwap :  MonoBehaviour {

	public Material platformy_inmotion;
	public Material platformy_hover;
	public Material platformy;
	public bool isPlatformySelected = false;

	void Start( )
	{
		EventTrigger trigger = GetComponent<EventTrigger>( );
		EventTrigger.Entry entry = new EventTrigger.Entry( );
		entry.eventID = EventTriggerType.PointerDown;
		entry.callback.AddListener( ( data ) => { OnPointerDownDelegate( (PointerEventData)data ); } );
		trigger.triggers.Add( entry );

		EventTrigger trigger2 = GetComponent<EventTrigger>( );
		EventTrigger.Entry entry2 = new EventTrigger.Entry( );
		entry.eventID = EventTriggerType.PointerEnter;
		entry.callback.AddListener( ( data ) => { OnPointerEnterDelegate( (PointerEventData)data ); } );
		trigger2.triggers.Add( entry2 );

		EventTrigger trigger3 = GetComponent<EventTrigger>( );
		EventTrigger.Entry entry3 = new EventTrigger.Entry( );
		entry.eventID = EventTriggerType.PointerExit;
		entry.callback.AddListener( ( data ) => { OnPointerExitDelegate( (PointerEventData)data ); } );
		trigger3.triggers.Add( entry3 );
	}

	public void OnPointerDownDelegate( PointerEventData data )
	{
		Renderer rend = GetComponent<Renderer>();

		if (isPlatformySelected == false) {
			rend.material = platformy_inmotion;
			isPlatformySelected = true;
		} else {
			rend.material = platformy;
			isPlatformySelected = false;
		}

	}

	public void OnPointerEnterDelegate( PointerEventData data )
	{
		Renderer rend = GetComponent<Renderer>();

		if (isPlatformySelected == false)
			rend.material = platformy_hover;
		
	}

	public void OnPointerExitDelegate( PointerEventData data )
	{
		Renderer rend = GetComponent<Renderer>();

		if(isPlatformySelected == false)
			rend.material = platformy;
			isPlatformySelected = true;
	}

}

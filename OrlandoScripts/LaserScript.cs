using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour
{
	public LineRenderer laserLineRenderer;
	public float laserWidth = 0.1f;
	public float laserMaxLength = 5f;

	public Rigidbody rb;
	public Vector3 v = new Vector3();
	public Vector3 direction = new Vector3();
	public Vector3 localDirection = new Vector3();
	public Vector3 lastPosition = new Vector3();

	void Start() {
		Vector3[] initLaserPositions = new Vector3[ 2 ] { Vector3.zero, Vector3.zero };
		laserLineRenderer.SetPositions( initLaserPositions );
		laserLineRenderer.SetWidth( laserWidth, laserWidth );

		rb = GetComponent<Rigidbody>();
	}

	void Update() 
	{
		lastPosition = transform.position;
		//direction = transform.position - lastPosition;
		//localDirection = transform.InverseTransformDirection(direction);
		//lastPosition = transform.position;
		ShootLaserFromTargetPosition( transform.position, lastPosition , laserMaxLength ); // need to get the direction as second input (Vector 3)
		laserLineRenderer.enabled = true;
	}

	void ShootLaserFromTargetPosition( Vector3 targetPosition, Vector3 direction, float length )
	{
		Ray ray = new Ray( targetPosition, direction );
		RaycastHit raycastHit;
		Vector3 endPosition = targetPosition + ( length * direction );

		if( Physics.Raycast( ray, out raycastHit, length ) ) {
			endPosition = raycastHit.point;
		}

		laserLineRenderer.SetPosition( 0, targetPosition );
		laserLineRenderer.SetPosition( 1, endPosition );
	}
}
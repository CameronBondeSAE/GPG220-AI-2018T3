using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
	public GameObject character;
	// public GameObject feeler;

	public float rotationSpeed;
	private Vector3 rotationVector;

	private RaycastHit rayHit;
	private int rayDistance = 1;
	public float rayScale;

	// Use this for initialization
	void Start ()
	{
		rotationVector.y = rotationSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 fwd = transform.forward;

		if (Physics.Raycast(transform.position, fwd, out rayHit, rayDistance * rayScale))
		{
			character.GetComponent<Rigidbody>().transform.Rotate(rotationVector);
			
			Debug.Log("Something was hit");
		}

		// Debug.DrawRay(feeler.transform.position, Vector3.forward, Color.magenta);
	}
}

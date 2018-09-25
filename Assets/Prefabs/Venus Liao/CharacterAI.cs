using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour
{
	public float MoveSpeed;
	private Vector3 ForwardForce;

	// Use this for initialization
	void Start ()
	{
		ForwardForce.z = MoveSpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 ProjectedLocation = transform.position + ForwardForce;

		GetComponent<Rigidbody>().AddForce(ForwardForce);
		Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), MoveSpeed);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*10, Color.green);
	}
}

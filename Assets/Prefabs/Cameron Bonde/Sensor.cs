using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
	public float distance;
	public Vector3 speed;
	private RaycastHit hitInfo;
	private Ray ray;

	public Rigidbody rb; // HACK the sensor shouldn't really be doing direct manipulation
	public Transform mainTransform;
	public Transform t;

	// Use this for initialization
	void Start()
	{
		Physics.autoSyncTransforms = false;

		ray = new Ray();

		mainTransform = rb.transform;
		t = transform;
	}

	// Update is called once per frame
	void Update()
	{
		ray.direction = t.forward;
		ray.origin = t.position;

		Physics.Raycast(ray, out hitInfo, distance);

		if (hitInfo.collider)
		{
//			print("HITTING");
			mainTransform.Rotate(speed.x, speed.y, 0);
			rb.AddRelativeForce(0,0,speed.z * (distance - hitInfo.distance));
		}
	}
}

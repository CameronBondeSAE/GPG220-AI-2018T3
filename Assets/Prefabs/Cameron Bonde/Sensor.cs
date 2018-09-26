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

	// Use this for initialization
	void Start()
	{
		ray = new Ray();
	}

	// Update is called once per frame
	void Update()
	{
		ray.direction = transform.forward;
		ray.origin = transform.position;

		Physics.Raycast(ray, out hitInfo, distance);

		if (hitInfo.transform)
		{
//			print("HITTING");
			rb.transform.Rotate(speed.x, speed.y, 0);
			rb.AddRelativeForce(0,0,speed.z * (distance - hitInfo.distance));
		}
	}
}

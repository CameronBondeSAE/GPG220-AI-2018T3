using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAI : MonoBehaviour
{
	public float MoveSpeed;
    public float RotateSpeed;
    public float RaycastMultiplier;
    public float DistanceScaler;

	private Vector3 ForwardForce;
    private Vector3 RotateForce;
    private RaycastHit hit;

	// Use this for initialization
	void Start ()
	{
		ForwardForce.z = MoveSpeed;
        //ForwardForce.x = MoveSpeed;
        RotateForce.y = RotateSpeed;
        //RotateForce = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Vector3 ProjectedLocation = transform.position + ForwardForce;

		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * MoveSpeed);
            //'Addforce' is a world-based force (think wind)

        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(RotateForce), Time.fixedDeltaTime);
        Vector3 transformDirection = transform.forward;

        Debug.DrawRay(transform.position, transformDirection, Color.red);
        if (Physics.Raycast(transform.position, transformDirection, out hit, DistanceScaler * RaycastMultiplier))
        {
			//Debug.DrawRay(transform.position, transformDirection, Color.red);
            //Debug.Log("Hit");
			//ForwardForce.x = MoveSpeed;
			transform.Rotate(RotateForce);
            //RotateForce.y -= 10;
        }
//        Debug.DrawRay(transform.position, transform.TransformDirection(transform.forward)*5, Color.green);
	}
}

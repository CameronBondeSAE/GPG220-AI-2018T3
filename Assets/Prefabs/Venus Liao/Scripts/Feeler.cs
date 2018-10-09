using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeler : MonoBehaviour
{
    public GameObject PlayerChara;
    public float RaycastScaler;
    public float TurnSpeed;

    private float RaycastDistance = 1;
    private RaycastHit hit;
    private Vector3 TurnVector;

    // Use this for initialization
    void Start ()
    {
        TurnVector.y = TurnSpeed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 forwardDirection = transform.forward;

        if(Physics.Raycast(transform.position, forwardDirection, out hit, RaycastDistance * RaycastScaler))
        {
            PlayerChara.GetComponent<Rigidbody>().transform.Rotate(TurnVector);
            //Debug.Log("HIT");
        }
	}
}

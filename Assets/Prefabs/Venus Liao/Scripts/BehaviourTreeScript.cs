using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTreeScript : MonoBehaviour
{
    public bool TestBool
    {
        get
        {
            return _testBool;
        }
        set
        {
            _testBool = value;
        }
    }

    public bool _testBool;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

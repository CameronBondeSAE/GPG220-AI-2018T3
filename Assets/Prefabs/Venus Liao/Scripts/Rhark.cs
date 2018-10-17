using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhark : MonoBehaviour
{
    /*public int ActionInt
    {
        get
        {
            return _actionInt;
        }
        set
        {
            _actionInt = value;
        }
    }
    public int _actionInt;*/

    public bool TwoEnemiesNearby
    {
        get
        {
            return _twoEnemiesNearby;
        }
        set
        {
            _twoEnemiesNearby = value;
        }
    }
    public bool _twoEnemiesNearby;

    public bool NoEnemiesNearby
    {
        get
        {
            return _noEnemiesNearby;
        }
        set
        {
            _noEnemiesNearby = value;
        }
    }
    public bool _noEnemiesNearby;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

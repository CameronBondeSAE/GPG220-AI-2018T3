using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sakon : MonoBehaviour
{
    public bool AlliesNearby
    {
        get
        {
            return _alliesNearby;
        }
        set
        {
            _alliesNearby = value;
        }
    }
    public bool _alliesNearby;

    public bool EnemiesNearby
    {
        get
        {
            return _enemiesNearby;
        }
        set
        {
            _enemiesNearby = value;
        }
    }
    public bool _enemiesNearby;

    public int RegenHealth
    {
        get
        {
            return _regenHealth;
        }
        set
        {
            _regenHealth = value;
        }
    }
    public int _regenHealth;

    public int TotalAllies
    {
        get
        {
            return _totalAllies;
        }
        set
        {
            _totalAllies = value;
        }
    }
    public int _totalAllies;

	// Use this for initialization
	void Start ()
    {
        _regenHealth = 10 * _totalAllies;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

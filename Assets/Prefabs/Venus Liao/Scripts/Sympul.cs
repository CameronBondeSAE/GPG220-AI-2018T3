using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sympul : MonoBehaviour
{
    public bool BackStab
    {
        get
        {
            return _backStab;
        }
        set
        {
            _backStab = value;
        }
    }
    public bool _backStab;

    public int SlashDamage
    {
        get
        {
            return _slashDamage;
        }
        set
        {
            _slashDamage = value;
        }
    }
    public int _slashDamage;

    public bool WithinRange
    {
        get
        {
            return _withinRange;
        }
        set
        {
            _withinRange = value;
        }
    }
    public bool _withinRange;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

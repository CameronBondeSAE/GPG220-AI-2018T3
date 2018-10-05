﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
	public float moveSpeed;
	public Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		rb.AddForce(0, 0, moveSpeed);
	}
}
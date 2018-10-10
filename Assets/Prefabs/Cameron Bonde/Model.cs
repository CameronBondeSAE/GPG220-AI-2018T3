using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cam
{


	public class Model : CharacterBase
	{
		public float speed;
		public bool normalBool;

		[SerializeField]
		private bool _isEnemyAngry;

		public bool IsEnemyAngry
		{
			

			// This get run when the variable is read
			get
			{
				return _isEnemyAngry;
			}
			// This gets run when it's set. Note the 'value' variable is unique to Properties and contains the real value
			set
			{
				_isEnemyAngry = value;
			}
		}

		public override void Ability1()
		{
			base.Ability1();

			debugText = "Ability1";
		}

		public bool IsEnemyNear()
		{
			// Do fancy code here
			return true;
		}

		// Use this for initialization
		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{
			GetComponent<Rigidbody>().AddRelativeForce(0,0,speed);
		}
	}

}

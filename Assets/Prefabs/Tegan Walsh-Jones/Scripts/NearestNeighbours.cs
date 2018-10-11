using System.Collections;
using System.Collections.Generic;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class NearestNeighbours : MonoBehaviour
{
	public List<CharacterBase> characterBases;

	void OnTriggerEnter(Collider other)
	{ 
		if (other.GetComponent<CharacterBase>())
		{
			characterBases.Add(other.GetComponent<CharacterBase>());
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<CharacterBase>())
		{
			characterBases.Remove(other.GetComponent<CharacterBase>());
		}
	}
}

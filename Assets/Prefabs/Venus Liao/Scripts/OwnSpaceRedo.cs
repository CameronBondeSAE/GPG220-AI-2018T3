﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnSpaceRedo : MonoBehaviour
{
    private List<CharacterBase> characters;

    void Start()
    {
        List<CharacterBase> characters = new List<CharacterBase>();

        /*
        Neighbour.Add(new Neighbours("Sympul", 1));
        Neighbour.Remove()

        */
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            characters.Add(other.gameObject.GetComponent<CharacterBase>());
            foreach (CharacterBase chara in characters)
            {
                print(chara.characterName);
            }
            //Debug.Log("Hello World");
        }
    }
}

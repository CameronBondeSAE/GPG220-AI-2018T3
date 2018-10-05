using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnSpace : MonoBehaviour
{
    private List<CharacterBase> characters;

    void Start()
    {
        List<CharacterBase> characters = new List<CharacterBase>();

        /*Neighbour.Add(new Neighbours("Rhark", 2));
        Neighbour.Add(new Neighbours("Sympul", 1));
        Neighbour.Remove()

        foreach (Neighbours chara in Neighbour)
        {
            print(chara.NeighbourName);
        }*/
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Character")
        {
            characters.Add(other.GetComponent<CharacterBase>());
            foreach(CharacterBase chara in characters)
            {
                print(chara.characterName);
            }
        }
    }
}

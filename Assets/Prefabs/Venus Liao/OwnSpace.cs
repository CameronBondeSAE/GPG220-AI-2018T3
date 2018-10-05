using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnSpace : MonoBehaviour
{
<<<<<<< HEAD
    private List<CharacterBase> characters;

=======
    private List<Neighbours> Neighbour;
>>>>>>> 39b44af4c35db3275068a0efd0aad0b26d033609
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
<<<<<<< HEAD
        if (other.tag == "Character")
        {
            characters.Add(other.GetComponent<CharacterBase>());
            foreach(CharacterBase chara in characters)
            {
                print(chara.characterName);
            }
=======
        if (other.tag == Character)
        {
            string NearbyName;
            NearbyName = other.GetComponent<CharacterBase>().characterName;
            print(NearbyName);

            /*Neighbour.Add(new Neighbours(NearbyName, 0));

            foreach (Neighbours chara in Neighbour)
            {
                print(chara.NeighbourName);
            }*/
>>>>>>> 39b44af4c35db3275068a0efd0aad0b26d033609
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnSpace : MonoBehaviour
{
    private List<Neighbours> Neighbour;
    void Start()
    {
        List<Neighbours> Neighbour = new List<Neighbours>();

        /*
        Neighbour.Add(new Neighbours("Sympul", 1));
        Neighbour.Remove()

        */
    }

    public void OnTriggerEnter(Collider other)
    {
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
        }
    }
}

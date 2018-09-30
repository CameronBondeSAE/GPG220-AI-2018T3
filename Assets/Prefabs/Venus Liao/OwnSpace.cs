using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnSpace : MonoBehaviour
{
    void Start()
    {
        List<Neighbours> Neighbour = new List<Neighbours>();

        Neighbour.Add(new Neighbours("Rhark", 2));
        Neighbour.Add(new Neighbours("Sympul", 1));
        Neighbour.Remove()

        foreach (Neighbours chara in Neighbour)
        {
            print(chara.NeighbourName);
        }
    }

}

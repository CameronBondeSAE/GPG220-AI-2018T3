using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Neighbours : IComparable<Neighbours>
{
    public string NeighbourName;
    public int power;

    public Neighbours (string NewName, int NewPower)
    {
        NeighbourName = NewName;
        power = NewPower;
    }

    public int CompareTo(Neighbours other)
    {
        if(other == null)
        {
            return 1;
        }

        return power - other.power;
    }
}

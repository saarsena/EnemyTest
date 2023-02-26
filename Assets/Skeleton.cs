using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public float h, av, noa = 0;

    public Skeleton()
    {
           
    }

    public Skeleton(float health, float atkvalue, int numberofattacks)
    {
        h = health;
        av = atkvalue;
        noa = numberofattacks;
    }

}

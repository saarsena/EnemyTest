using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Skeleton skeletonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnSkele(300, 50, 1);
        Skeleton skeleton = Instantiate(skeletonPrefab, new Vector3(0, 0, 0), Quaternion.identity) as Skeleton;
        skeleton.h = 75f;
        Debug.Log(skeleton.h);

    }

    void SpawnSkele(float health, float attackvalue, int numberofattacks)
    {
        Skeleton skeleton = Instantiate(skeletonPrefab, new Vector3(0, 0, 0), Quaternion.identity) as Skeleton;
        skeleton.h = health;
        skeleton.av = attackvalue;
        skeleton.noa = numberofattacks;
    }
}


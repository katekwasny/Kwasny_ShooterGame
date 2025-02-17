﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    public static AmmoManager AmmoManagerSingleton = null;
    public GameObject AmmoPrefab = null;
    public int PoolSize = 100;
    public Queue<Transform> AmmaQueue = new Queue<Transform>();
    private GameObject[] AmmoArray;

    private void Awake()
    {
        if(AmmoManagerSingleton != null)
        {
            Destroy(GetComponent<AmmoManager>());
            return;
        }
        AmmoManagerSingleton = this;
        AmmoArray = new GameObject[PoolSize];

        for (int i = 0; i < PoolSize; ++i)
        {
            AmmoArray[i] = Instantiate(AmmoPrefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            Transform ObjTransform = AmmoArray[i].transform;
            AmmaQueue.Enqueue(ObjTransform);
            AmmoArray[i].SetActive(false);
        }
    }
    public static Transform SpawnAmmo(Vector3 Postion, Quaternion Rotation)
    {
        Transform SpawnedAmmo = AmmoManagerSingleton.AmmaQueue.Dequeue();
        SpawnedAmmo.gameObject.SetActive(true);
        SpawnedAmmo.position = Postion;
        SpawnedAmmo.localRotation = Rotation;
        AmmoManagerSingleton.AmmaQueue.Enqueue(SpawnedAmmo);
        return SpawnedAmmo;
    }

}

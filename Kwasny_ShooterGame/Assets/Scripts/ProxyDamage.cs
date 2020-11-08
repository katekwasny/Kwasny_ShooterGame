﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    //Damage per second
    public float DamageRate = 10f;

    private void OnTriggerStay(Collider Col)
    {
        Health H = Col.gameObject.GetComponent<Health>();
        if (H == null)
            return;
        H.HealthPoints -= DamageRate * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

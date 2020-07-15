﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     Animator anim;
    [SerializeField] private float destroyDistance;
    private Vector3 initPos;
    

    void Start()
    {
        initPos = transform.position;
       
        
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        
        if (Vector3.Distance(initPos, transform.position) > destroyDistance)
        {
            anim.SetTrigger("Destroy");
            Destroy(gameObject, 1.5f);

        }
        
    }
    
    
    

}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : EnemyController
{
    // Use this for initialization
    public override void Start()
    {
        base.Start();
	}
	
	// Update is called once per frame
	public override void Update ()
    {
        rotateTowardsPlayer();

        moveTowardsPlayer();
        
        if (isOnScreen())
        {
            shoot();
        }
    }
}

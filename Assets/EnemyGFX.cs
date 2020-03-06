﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{

    public AIPath aIPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aIPath.desiredVelocity.x >=0.01)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }else if (aIPath.desiredVelocity.x <= -0.01)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        
    }
}

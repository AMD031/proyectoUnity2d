﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int health =100;
    
    public void TakeDamege(int damage)
    {
        health -= damage;

        if (health<=0)
        {

            Die();

        }


    }


    public void Die()
    {
        //Instantiate(null ,transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}

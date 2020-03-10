using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StalactiteDamage : MonoBehaviour
{
    public GameObject player;
    public int damge = 5;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="player")
        {
            player.GetComponent<PlayerHealth>().TakeDamage2(damge);

        }


        
    }



}

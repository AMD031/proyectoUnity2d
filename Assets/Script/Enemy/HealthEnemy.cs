using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthEnemy : MonoBehaviour
{



    public  SpriteRenderer spriteRenderer;
    public int health =100;
    public AudioClip hit;
    private AudioSource audio;


    // Update is called once per frame

    private void Awake()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = hit;
    }



    public void TakeDamege(int damage)
    {
        if (audio!=null)
        {
            audio.Play();
        }
 
        health -= damage;
        this.spriteRenderer.color = new Color(0,150,0,50);
        if (health<=0)
        {
            Die();
        }


    }


    public void Die()
    {
        //Instantiate(null ,transform.position, Quaternion.identity);
        GameObject parent =   gameObject.transform.parent.gameObject;
        Destroy(parent);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    Animator animator;
    BoxCollider2D bc2d;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        bc2d = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="player")
        {

            StartCoroutine(ActivateTrap());


        }


    }

    IEnumerator ActivateTrap()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("activate", true);
        bc2d.enabled = false;
    }



}

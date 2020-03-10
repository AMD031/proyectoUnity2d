using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalactite : MonoBehaviour
{
    public  GameObject stalactite;
    private Rigidbody2D rb2D;
    private bool startFall;
    public float timeStartFall = 0.20f;
  


    void Start()
    {
        rb2D = stalactite.GetComponent<Rigidbody2D>();
        startFall = false;
    }

    void FixedUpdate()
    {
        // Cast a ray straight down.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        Debug.DrawRay(transform.position, -Vector3.up* 15, Color.green);

      

        if (startFall == true)
        {
            StartCoroutine(Move());
        }

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.tag=="player")
            {
                if (startFall == false)
                {
                    StartCoroutine(StartMove());
                    StartCoroutine(Delete());
                }


            }

        }

    }

    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(10f);
        startFall = true;

    }

    private IEnumerator StartMove()
    {
        yield return new WaitForSeconds(timeStartFall);
        startFall = true;


    }

    private IEnumerator Move()
    {
        rb2D.transform.position += Time.deltaTime * Vector3.down * 10;
        yield return null;
    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("enemigo dañado");
            rb.velocity =Vector2.zero;
            collision.gameObject.GetComponent<Health>().TakeDamege(50);
            this.coroutine = DestroyObject(1.0f);
            StartCoroutine(this.coroutine);
        }
       
     
    }


    IEnumerator DestroyObject(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
            Destroy(gameObject);
        }
      
       
    }

    








}

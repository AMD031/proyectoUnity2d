using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            rb.velocity =Vector2.zero;
            collision.gameObject.GetComponent<HealthEnemy>().TakeDamege(50);
            // StartCoroutine(DestroyObject(1.0f));
            Destroy(gameObject);
        }
       
     
    }


    IEnumerator DestroyObject(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(gameObject);
        }
      
       
    }

    








}

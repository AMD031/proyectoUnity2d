using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

       
        rb.velocity = Vector2.right * speed;

        


    }


    private void Update()
    {

        if (Input.GetButtonDown("Fire1")){
           Debug.Log(right(player.transform.position.normalized, gameObject.transform.position.normalized));
        }


    }


    private bool right(Vector2 a, Vector2 b)
    {
        float dot = a.x * -b.y + a.y * b.x;
        bool right= false;

        if (dot > 0)
        {
            right = false;
        }
        else if (dot < 0)
        {
           right = true;
        }
        return right;         
    }





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    GameObject player;
    public GameObject skull;
    GameObject IEnemy;
    public float distanceSpawn = 7;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="player")
        {
            InstantiateEnemy();
        }
    }

        void InstantiateEnemy()
    {
        if (IEnemy ==null)
        {
        float value = Random.Range(-10.0f, 10.0f);
        if (player != null)

        {
            if (value>=0)
            {
                IEnemy =  Instantiate(skull, player.transform.position + (Vector3.right * distanceSpawn), Quaternion.identity);
            }
            else
            {          
                IEnemy =  Instantiate(skull, player.transform.position + (Vector3.left * distanceSpawn), Quaternion.identity);
            }

         }

       }
    }




}

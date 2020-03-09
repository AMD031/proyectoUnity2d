using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public AudioClip fire;
    private AudioSource audio;




    private void Awake()
    {
        audio = gameObject.GetComponent<AudioSource>();
        audio.clip = fire;
    }



    public GameObject magicFire;
    public float v =0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="player")
        {
            GameObject player = collision.gameObject;
            StartCoroutine(die(player));
        }

    }


    IEnumerator die(GameObject player)
    {
        Transform transform = player.gameObject.transform;
        if (magicFire !=null)
        {
            Instantiate(magicFire, transform.position +(Vector3.down*v), Quaternion.identity);
        }
        if (audio != null)
        {
            audio.Play();
        }
        player.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level1");

    }




}

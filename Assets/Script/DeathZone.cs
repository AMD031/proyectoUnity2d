using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public GameObject magicFire;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="player")
        {

            Debug.Log("entra");
            GameObject player = collision.gameObject;
            StartCoroutine(die(player));
        }

    }


    IEnumerator die(GameObject player)
    {
        Transform transform = player.gameObject.transform;
        if (magicFire !=null)
        {
            Instantiate(magicFire, transform.position, Quaternion.identity);
        }

        player.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level1");

    }




}

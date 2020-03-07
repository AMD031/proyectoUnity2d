using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{ 
    public Slider slider;
    public GameObject player;


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }


    public void SetHealth(int health)
    {
        slider.value = health;
        if (slider.value <=0)
        {

            GameObject magicFire = player.transform.GetChild(3).gameObject;

            if (magicFire!=null && magicFire.name.Equals("magicFire"))
            {
                magicFire.SetActive(true);
                StartCoroutine(deactivatePlayer());
            }
            else{
                Debug.Log("no se encuentra magicFire");
            }


           
        }
    }



    IEnumerator deactivatePlayer()
    {
        yield return new WaitForSeconds(1f);
        player.SetActive(false);
        SceneManager.LoadScene("Level1");
    }






}

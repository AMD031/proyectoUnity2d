using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    private float myTime = 0.0F;
    public float fireDelta = 0.5F;
    private float nextFire = 0.5F;

    // Update is called once per frame
    void Update()
    {
        myTime +=  Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire)
        {

            nextFire = myTime + fireDelta;
            Shoot();
            // create code here that animates the newProjectile

            nextFire -= myTime;
            myTime = 0.0F;

        }
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);


    }


}

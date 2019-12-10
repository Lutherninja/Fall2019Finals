using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Weapon : MonoBehaviour
{

    public Transform firePoint;
    public Transform crouchingFirepoint;
    public GameObject bulletPrefab;
    public bool  isCrouching;
    public AudioSource pew;



    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
            pew.Play();
        }

        if (Input.GetButtonDown("P2Crouch"))
        {
            isCrouching = true;
        }

        if (Input.GetButtonUp("P2Crouch"))
        {
            isCrouching = false;
        }
    }

    void Shoot()
    {
        // shooting logic
        if (isCrouching)
        {
            Instantiate(bulletPrefab, crouchingFirepoint.position, crouchingFirepoint.rotation);
            
        }
        else
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }


    }

}


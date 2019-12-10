using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public Transform crouchingFirepoint;
    public GameObject bulletPrefab;
    public bool  isCrouching;
    public AudioSource pewpew;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            pewpew.Play();
        }

        if (Input.GetButtonDown("Crouch"))
        {
            isCrouching = true;
        }

        if (Input.GetButtonUp("Crouch"))
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


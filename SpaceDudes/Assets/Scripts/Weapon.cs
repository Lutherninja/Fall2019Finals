using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public Transform crouchingFirepoint;
    public Transform aimingUpFirePoint;
    public GameObject bulletPrefab;
    public bool  isCrouching;
    public bool isAimingUp;
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

        if (Input.GetButtonDown("P1Up"))
        {
            isAimingUp = true;
        }

        if (Input.GetButtonUp("P1Up"))
        {
            isAimingUp = false;
        }
    }

    void Shoot()
    {
        // shooting logic
        if (isCrouching)
        {
            Instantiate(bulletPrefab, crouchingFirepoint.position, crouchingFirepoint.rotation);
            
        }
        else if (isAimingUp)
        {
            Instantiate(bulletPrefab, aimingUpFirePoint.position, aimingUpFirePoint.rotation);
        }
        else
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }


    }

}


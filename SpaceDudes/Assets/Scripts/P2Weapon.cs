using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Weapon : MonoBehaviour
{

    public Transform firePoint;
    public Transform crouchingFirepoint;
    public Transform aimingUpFirepoint;
    public GameObject bulletPrefab;
    public bool  isCrouching;
    public bool isAimingUp;
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

        if (Input.GetButtonDown("P2Up"))
        {
            isAimingUp = true;
            print("isaimingup dummy");
        }

        if (Input.GetButtonUp("P2Up"))
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
            Instantiate(bulletPrefab, aimingUpFirepoint.position, aimingUpFirepoint.rotation);
        }
        else
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }


    }

}


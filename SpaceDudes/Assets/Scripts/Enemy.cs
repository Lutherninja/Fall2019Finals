  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Events;

public class Enemy : MonoBehaviour {

    public int health = 3;
    public UnityEvent GameOver;

   // public ParticleSystem deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        print("u ded");
        GameOver.Invoke();

    }

}
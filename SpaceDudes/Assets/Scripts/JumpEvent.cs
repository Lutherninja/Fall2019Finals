using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpEvent : MonoBehaviour
{
    public UnityEvent Landing;
    public Animator animator;

    private void OnTriggerStay2D(Collider2D other)
    {
        Landing.Invoke();
        Debug.Log("ur mom gay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        animator.SetBool("IsJumping", true);
    }
}

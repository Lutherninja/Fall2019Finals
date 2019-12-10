using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float horizontalMove = 0f;

    float runSpeed = 30f;

    private bool jump = false;

    public bool crouch = false;

    public UnityEvent Rotate;
    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (horizontalMove < 0)
        {
            Rotate.Invoke();
        }


        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("IsJumping", true);
            jump = true;
            
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;{}
            
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    
    public void OnLanding ()
    {
        print("ur mom gay");
        animator.SetBool("IsJumping", false);
        
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        //Move Character
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;
        

    }
}

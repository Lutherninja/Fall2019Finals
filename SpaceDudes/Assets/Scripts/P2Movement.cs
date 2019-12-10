using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class P2Movement : MonoBehaviour
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
       horizontalMove = Input.GetAxisRaw("P2Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if (horizontalMove < 0)
        {
            Rotate.Invoke();
        }


        if (Input.GetButtonDown("P2Jump"))
        {
            animator.SetBool("IsJumping", true);
            jump = true;
            print("p2 jumpity");

        }
        if (Input.GetButtonDown("P2Crouch"))
        {
            crouch = true;{}
            print("p2 Crouchity");
            
        } else if (Input.GetButtonUp("P2Crouch"))
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

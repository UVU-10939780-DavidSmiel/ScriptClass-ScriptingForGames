using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        
        if (Input.GetAxis("Horizontal") != 0){
            animator.SetTrigger("Run");
        }
        else {
            animator.SetTrigger("Idle");
        }


        if (Input.GetButtonDown("Jump")){
            animator.SetTrigger("Jump");
        }
        
    //// Test stuff
        if (Input.GetKeyDown(KeyCode.W)){
            animator.SetTrigger("WallJump");
        }

        if (Input.GetKeyDown(KeyCode.H)){
            animator.SetTrigger("Hit");
        }
    }
}

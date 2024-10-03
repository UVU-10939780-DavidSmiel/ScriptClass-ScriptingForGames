using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 9f;
    public float gravity = -9.91f;



    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    
    //private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //chache reference to componts
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGravity();
        MoveCharacter();
        KeepCharacterOnAxis();
    }

    private void MoveCharacter() {

        //horizontal move
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);


        //Jumpy
        if (Input.GetButtonDown("Jump") && controller.isGrounded){
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }


///Older for understnaidn purpose
            ////movementVector.x = Input.GetAxis("Horizontal");
            ////movementVector *= (moveSpeed * Time.deltaTime);
            ////controller.Move(movementVector);
    }

    private void ApplyGravity() 
    {
        ///apply the gravity
        if (!controller.isGrounded){
            velocity.y += gravity * Time.deltaTime;
        } else {
            velocity.y = 0f;
        }

        /// apply the veolcity the controler
        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnAxis() {
        ///Use cahce tranformrefence and optmize
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }


}

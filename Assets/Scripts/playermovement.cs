using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 7f;
    public float gravity = -9.88f;
    public float jumpHeight = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;
    AudioSource au;
    public AudioClip jampu;
    
    bool isGrounded;
    
    Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //check for ground

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal"); //player movement on x axis
        float z = Input.GetAxis("Vertical"); //[layer movement on z axis

        Vector3 move = transform.right * x + transform.forward * z; //movement

        controller.Move(move * speed * Time.deltaTime); //movement speed

        if(Input.GetButtonDown("Jump") && isGrounded)//jumps if detects player on ground
        {
            Debug.Log("You Jumped");
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);//jump physics
            au = GetComponent<AudioSource>();
            au.PlayOneShot(jampu);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}

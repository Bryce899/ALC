using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // set speed value
    public float rotSpeed; //rotation
    public float hInput; // Horizontal speed
    public float vInput; // Vertical input
    public float jumpForce; // jump height
    public Rigidbody playerRB; // Reference Rigidbody compoent 

    // update is called once per frame
    void Update()
    {

        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime)
        ;
        
        // Rotate Left and Right

        transform.Translate(Vector3.forward * speed * vInput * Time.
        deltaTime);//Forward and backward movement
        if (Input.GetKeyDown(KeyCode.Space)) // check for space bar press
            playerRB.AddForce(Vector3.up*jumpForce, ForceMode.Impulse); // makes player jump
        
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed;// Movement speed in units per second
    public float jumpForce;// force applied to the y axis to make the player jump up
    [Header("Camera Info")]
    public float lookSensitivity;// mouse look sensitivity
    public float maxLookX;// Lowest point you can look down
    public float minLookX;//Highest point you can look up
    public float rotX;// Current x rotation of the camera
    [Header("Private Variables")]
    private Camera camera;// references the main camera
    private Rigidbody rb;// reference the rigidbody compoent



    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        //Getcompoents
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;//Move left and right input
        float z = Input.GetAxis("Vertical") * moveSpeed;//Move foward and back  input

        rb.velocity = new Vector3(x, rb.velocity.y, z); // Applys velocity on x and z axes. It makes it move


    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse x") * lookSensitivity;
        rotX += Input.GetAxis("Mouse y") * lookSensitivity;
    }
}

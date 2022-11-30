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
    private float rotX;// Current x rotation of the camera
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
        //Freeze and awake
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();

        if (Input.GetButtonDown("Jump"))
            PlayerJump();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;//Move left and right input
        float z = Input.GetAxis("Vertical") * moveSpeed;//Move foward and back  input

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;

        rb.velocity = dir; // Applys velocity on x and z axes. It makes it move


    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);// clamp the vertical rotation of the player so he doesent do weird camera angle flips
        //apply rotation to the player
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {
        //ground detection
        Ray ray = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
      
    }
}

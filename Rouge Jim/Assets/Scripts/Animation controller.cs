using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationcontroller : MonoBehaviour
{
    public Animator animSpeed;
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        //Get Animator and animation Compoents
        animSpeed = GetComponent<Animator>();
        anim = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) PlayAnim();

        if (Input.GetKeyDown(KeyCode.S)) StopAnim();
            
         
         
        
    }

    // control animation via animator and keys
    void PlayAnim()
    {
        animSpeed.speed = 1f;
        Debug.Log("Animation is Playing");
    }

    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation is Paused");
    }
   
}

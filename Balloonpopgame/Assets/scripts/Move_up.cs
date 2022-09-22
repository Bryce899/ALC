using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_up : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperbound = 25.0f;
    private Balloon balloon;

    private ScoreManager scoreManager; // a variable to reference the scoreManager

    // Start is called before the first frame update
    void Start()
    {
        //reference scoreManager compoent
        scoreManager = GameObject.Find("ScoreManager").
        GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>(); // references ballon script
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the Balloon upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //Destroy Ballon after it passes upperbound
        if(transform.position.y > upperbound)
        {
            ScoreManager.DecreaseScoreText(balloon.scoreToGive);// substract scoretogive from total score

            Destroy(gameObject);// Pop Balloon


        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // how many clicks before ballon pops

    public float scaleToIncrease = 0.10f; //scale increase each time the ballon is clicked

    public int scoreToGive = 100; // score give for popped balloon.

    private ScoreManager scoreManager; // a variable to reference the scoreManager


    // Start is called before the first frame update
    void Start()
    {
        // reference score manager compoent
        scoreManager = GameObject.Find("ScoreManager").
        GetComponent<ScoreManager>();



    }

    void OnMouseDown()
    {
        //reduce clicks by one
        clickToPop -= 1;

        // Increase balloon volume
        transform.localScale += Vector3.one *
        scaleToIncrease;

        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }    
     }



         

}


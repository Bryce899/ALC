using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep track of the score
    public TextMeshProUGUI scoreText; // text ui object to be modfied


    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText(); // call updatescoretext function  

    }

    public void IncreaseScoreText(int amount)
    {
        score += amount; // increase score by amount
        UpdateScoreText(); // update score ui text

    }
    public void DecreaseScoreText(int amount)
    {
        score -= amount; // decrease score by amount
       UpdateScoreText();// update score
    }

    // Update is called once per frame
    public void UpdateScoreText();
    {
        ScoreText.text = "score" + score; 

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{

    public int key;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddKey(int amount)
    {
        key += amount;//Add keys to inventory
        Debug.Log("you have" + key + " keys");
    }
}


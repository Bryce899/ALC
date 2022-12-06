using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        rend = GetComponent<Renderer>(); // Finds and references the Gamemanager
        rend.enabled = true;// this makes the flag visble to the player
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gm.hasFlag = true;
            Debug.Log("You have captured the flag!");
            //this.gameObject.SetActive(false);
            rend.enabled = false;// Hides the flag
        }
    }
}

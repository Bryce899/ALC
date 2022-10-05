using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public string name;
    public string typeOfPickup;
    public string description;

    public int amount;
    public int value;

    private Game_Manager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").
        GetComponent<Game_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);
            Destroy(other.gameObject);


        }


    }


}

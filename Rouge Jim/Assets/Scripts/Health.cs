using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;// Take away a certain amount of health

        if(currentHealth <= 0)// Has the player expired like cereal 
        {
            Destroy(gameObject, deathDelay);
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)// Check to make sure currentHealth does not exeed max health for cheaters so they cant cheat becuase cheating is wrong and immoral
        {
            currentHealth = maxHealth;
        }


    }
}

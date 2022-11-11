using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemeyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1f;
    }



    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;// Take away a certain amount of health

        if (currentHealth <= 0)// Has the player expired like cereal 
        {
            Debug.Log("Enemy has Died!");
            Destroy(gameObject, deathDelay);
        }
    }
}
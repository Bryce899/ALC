using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShoot : MonoBehaviour
{
    public float speed;
    public float stopDistane;
    public float retreatDistance;
    private Transform target;
    private float shotDelay;
    public float startDelay;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
        shotDelay = startDelay;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistane)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopDistane && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);// RUNN AWAY!!!!
        }

        // Ranged attack
        if(shotDelay <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : MonoBehaviour
{
   public float speed;
    private Waypoints5 Wpoints;

    private int waypointIndex;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints5").GetComponent<Waypoints5>(); 
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints5[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints.waypoints5[waypointIndex].position) < 0.1f)
        {


            if (waypointIndex < Wpoints.waypoints5.Length - 1)
            {
                waypointIndex++;
            }
            else 
            {
                Destroy(gameObject);
                //InvokeRepeated("voidUpdate", 0.0f, 1.0f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        HeartSystem player2 = other.gameObject.GetComponent<HeartSystem >();
        if (player2 !=null)
        {
            player2.TakeDamage(1);
        }
    }
}

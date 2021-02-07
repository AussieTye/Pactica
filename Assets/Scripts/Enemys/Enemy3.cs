using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
     public float speed;
    private Waypoints3 Wpoints;

    private int waypointIndex;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints3").GetComponent<Waypoints3>(); 
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints3[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints.waypoints3[waypointIndex].position) < 0.1f)
        {


            if (waypointIndex < Wpoints.waypoints3.Length - 1)
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

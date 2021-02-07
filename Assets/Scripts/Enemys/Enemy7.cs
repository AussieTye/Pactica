using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy7 : MonoBehaviour
{
    public float speed;
    private Waypoints7 Wpoints;

    private int waypointIndex;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints7").GetComponent<Waypoints7>(); 
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints7[waypointIndex].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, Wpoints.waypoints7[waypointIndex].position) < 0.1f)
        {


            if (waypointIndex < Wpoints.waypoints7.Length - 1)
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

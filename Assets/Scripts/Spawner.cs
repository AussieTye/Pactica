using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;


    void Start()
    {

    }


    void Update()
    {


        if (Time.time > nextSpawn)
        {

            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);


        }

    }

}
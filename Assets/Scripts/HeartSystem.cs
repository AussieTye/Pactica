using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] Lives;
    public int life;
    private bool dead;
    // Start is called before the first frame update
    void Start()
    {
        life = Lives.Length;
    }

    // Update is called once per frame
    public void Update()
    {
        if (dead == true)
        {
            //SET DEAD CODE
        }
    }

   

    public void TakeDamage(int d)
    {
        life -= d;
        Destroy(Lives[life].gameObject);
        if(life < 1)
        {
            dead = true;
        }
    }
}

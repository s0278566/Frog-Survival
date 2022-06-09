using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public bool MovingUp = true;
    public bool stuck = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Frog")
        {
            Frog.Score+=2;
            Destroy(gameObject);
        }

        if (collision.transform.name == "Bubble(Clone)")
        {
            transform.SetParent(collision.transform);
            stuck = true;
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if(MovingUp)
        {
            transform.position += new Vector3(0, 0.01f, 0);
        }

        if(!MovingUp)
        {
            transform.position += new Vector3(0, -0.01f, 0);
        }

        if(transform.position.y >6)
        {
            MovingUp = false;
        }

        if(transform.position.y <-6)
        {
            MovingUp = true;
        }

        if(Random.value <0.005)
        {
            MovingUp = !MovingUp;
        }

    }
}

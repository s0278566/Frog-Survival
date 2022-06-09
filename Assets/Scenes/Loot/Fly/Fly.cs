using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public bool MovingRight = true;
    public bool stuck = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.name == "Frog")
        {
            Frog.Score++;
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
       
        if(stuck)
        {
            transform.position += new Vector3(0, -0.01f, 0);

        }

        if (!stuck)
        {
            if (MovingRight)
            {
                transform.position += new Vector3(0.01f, 0, 0);
            }

            if (!MovingRight)
            {
                transform.position += new Vector3(-0.01f, 0, 0);
            }

            if (transform.position.x > 6)
            {
                MovingRight = false;
            }

            if (transform.position.x < -6)
            {
                MovingRight = true;
            }

            if (Random.value < 0.005)
            {
                MovingRight = !MovingRight;
            }

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    public bool MovingRight = true;
    public bool Stuck = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Frog")
        {
            Frog.Score+=5;
            Destroy(gameObject);
        }

        if (collision.transform.name == "Bubble(Clone)")
        {
            transform.SetParent(collision.transform);
            Stuck = true;
        }
    }
    void Start()
    {
        
    }

   
  
   

    void Update()
  
    {
        if(!Stuck)
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

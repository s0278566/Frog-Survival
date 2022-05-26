using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public bool MovingUp = true;
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
        
        if(transform.position.y > 6)
        {
            MovingUp = false;
        }

        if(transform.position.y <-6)
        {
            Destroy(gameObject);
        }
    }
}

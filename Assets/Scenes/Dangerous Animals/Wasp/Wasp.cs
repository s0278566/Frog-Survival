using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool MovingUp = true;
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

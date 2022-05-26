using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosquito : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool MovingRight = true;
    void Update()
    {
        if(MovingRight)
        {
            transform.position += new Vector3(0.01f, 0, 0);
        }

        if(!MovingRight)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }

        if(transform.position.x >6)
        {
            MovingRight = false;
        }

        if(transform.position.x <-6)
        {
            MovingRight = true;
        }

        if(Random.value <0.005)
        {
            MovingRight = !MovingRight;
        }

    }
}

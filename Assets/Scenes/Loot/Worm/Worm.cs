using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool MovingRight = true;
    public bool Stuck = false;
  
   

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

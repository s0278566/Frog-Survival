using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject bubblePrefab;

    public static int Score = 0;

    public static int Health = 3;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
    
    }

 

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.01f, 0, 0);
        }


        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.01f, 0, 0);
        }


        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f, 0);
        }


        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.01f, 0);
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bubblePrefab, transform.position, Quaternion.identity);
        }
    
    




    }
}

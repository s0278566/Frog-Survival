using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Froghealth3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Frog.Health < 1)
        {
            Application.LoadLevel("Lose");
            Destroy(gameObject);
        }
    }
}

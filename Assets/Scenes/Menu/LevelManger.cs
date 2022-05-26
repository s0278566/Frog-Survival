using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour
{
public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }
}

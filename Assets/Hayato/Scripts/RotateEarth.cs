using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEarth : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(0, 0, 0.1f, Space.Self); 
    }
}

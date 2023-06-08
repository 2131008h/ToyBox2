using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public Transform cam_Transform;
    void Update()
    {
        cam_Transform.Rotate(Vector3.up, 35 * Time.deltaTime);
    }
}

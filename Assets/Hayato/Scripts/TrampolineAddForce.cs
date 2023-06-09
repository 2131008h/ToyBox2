using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineAddForce : MonoBehaviour
{
    public Rigidbody rb;
    //JumpPower=2推奨
    //JumpPower=250の場合JumpKey無効時に有効
    public float JumpPower;
    
    private Vector3 FlyAngle;
    [SerializeField] GameObject Main;
    private void FixedUpdate()
    {
        float angleDir = Main.transform.eulerAngles.z * (Mathf.PI / 180.0f);
        Vector3 dir = new Vector3(Mathf.Cos(angleDir), JumpPower, Mathf.Sin(angleDir));
        FlyAngle = dir;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.AddForce(FlyAngle, ForceMode.Impulse);
            rb.useGravity = true;
        }
    }
    
}

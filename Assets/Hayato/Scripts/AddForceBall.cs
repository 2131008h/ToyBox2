using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBall : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody[] rbWall;
    private Vector3 FlyBallAngle;
    public float BallPower;
    [SerializeField] GameObject Main;

    void Start() 
    { 
        rb = GetComponent<Rigidbody>();
        rbWall = GetComponent<Rigidbody[]>();

    }
    //FixedUpdate()ÇégópÇÃÇΩÇﬂíçà”ÇµÇƒÇ≠ÇæÇ≥Ç¢
    private void Update()
    {
        float angleDir = Main.transform.eulerAngles.z * (Mathf.PI / 180.0f);
        Vector3 dir = new Vector3(Mathf.Cos(angleDir), 1.0f, Mathf.Sin(angleDir)) ;
        FlyBallAngle = dir;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.AddForce(FlyBallAngle*BallPower, ForceMode.Force);
            rb.useGravity = true;
        }
        if (collision.gameObject.tag == "Wall")
        {
            rbWall[0].isKinematic = false;
            rbWall[1].isKinematic = false;
            rbWall[2].isKinematic = false;
            rbWall[3].isKinematic = false;
            rbWall[4].isKinematic = false;
            rbWall[5].isKinematic = false;
            rbWall[6].isKinematic = false;
            rbWall[7].isKinematic = false;
            rbWall[8].isKinematic = false;
            rbWall[9].isKinematic = false;
            rbWall[10].isKinematic = false;
            rbWall[11].isKinematic = false;
            rbWall[12].isKinematic = false;
            rbWall[13].isKinematic = false;
            rbWall[14].isKinematic = false;
            rbWall[15].isKinematic = false;
            rbWall[16].isKinematic = false;
            rbWall[17].isKinematic = false;
            rbWall[18].isKinematic = false;
            rbWall[19].isKinematic = false;
        }
    }
}

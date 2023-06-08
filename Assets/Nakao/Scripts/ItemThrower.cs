using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemThrower : MonoBehaviour
{

    public static ItemThrower instance;

    private void Awake()
    {
        instance = this;
    }

    private GameObject Ball;

    float startTime, endTime, swipeDistance, swipeTime;
    private Vector2 startPos;
    private Vector2 endPos;
    private Vector3 initialPos;

    public float MinSwipDist = 0;
    private float BallVelocity = 0;
    private float BallSpeed = 0;
    public float MaxBallSpeed = 10;
    private Vector3 angle;
    private float anglex;
    private float angley;
    private bool thrown, holding;
    private Vector3 newPosition;
    Rigidbody rb;

    public bool isThrowed = false;

    public bool IsFreezable = false;

    // Start is called before the first frame update
    void Start()
    {
        setupBall();
        //initialPos = Ball.transform.position;
    }

    void setupBall()
    {
        GameObject _ball =  ItemChanger.instance.ObjectChecker();
        //GameObject _ball = GameObject.FindGameObjectWithTag("Player");
        Ball = _ball;
        rb = Ball.GetComponent<Rigidbody>();

        ResetBall();
    }

    void ResetBall()
    {
        angle = Vector3.zero;
        endPos = Vector2.zero;
        startPos = Vector2.zero;
        BallSpeed = 0;
        startTime = 0;
        endTime = 0;
        swipeDistance = 0;
        swipeTime = 0;
        thrown = holding = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        Ball.transform.position = transform.position;
        //Ball.transform.position = initialPos;
        IsFreezable = false;
}

    void AfterBall()
    {
        angle = Vector3.zero;
        endPos = Vector2.zero;
        startPos = Vector2.zero;
        BallSpeed = 0;
        startTime = 0;
        endTime = 0;
        swipeDistance = 0;
        swipeTime = 0;
        thrown = holding = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = true;
        Ball.transform.position = transform.position;
        IsFreezable = false;
}

    void PickupBall()
    {
        if(Ball.tag == "Player"){
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane * 20f;
            newPosition = Camera.main.ScreenToWorldPoint(mousePos);
            Ball.transform.localPosition = Vector3.Lerp(Ball.transform.localPosition, newPosition, 80f * Time.deltaTime);
        }
        
    }

    private void Update()
    {
        if (holding)
            PickupBall();

        if (thrown)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hit;

            if (Physics.Raycast(ray, out _hit, 100f))
            {
                if (_hit.transform == Ball.transform)
                {
                    startTime = Time.time;
                    startPos = Input.mousePosition;
                    holding = true;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endTime = Time.time;
            endPos = Input.mousePosition;
            swipeDistance = (endPos - startPos).magnitude;
            swipeTime = endTime - startTime;

            if (swipeTime < 1f && swipeDistance > 0.1f)
            {
                //throw ball
                CalSpeed();
                CalAngle();
                //rb.AddForce(new Vector3(-1*anglex , 0, -1 * angley * BallSpeed/5));
                //rb.AddForce(new Vector3((angle.x * BallSpeed), (angle.y * BallSpeed)/0, (angle.z * BallSpeed)/10));
                //Debug.Log(anglex);
                //Debug.Log(angley);
                rb.AddForce(new Vector3(angley * 10, 0 , -anglex * 10));
                //rb.AddForce(new Vector3(2000,0,0));
                rb.useGravity = true;
                holding = false;
                thrown = true;
                Time.timeScale = 1f;
                FreezeAnauncer();
                Debug.Log("freezeしていいよー");
                Invoke("AfterBall", 4f);
                this.gameObject.tag = "Untagged";

                
                

            }
            else if(this.gameObject.tag == "Player")
            {
                ResetBall();
                Debug.Log("リセットしたよ");
            }

            Invoke("FreezeAnauncer", 7f);


        }
        
    }

    
    private void CalAngle()
    {
        anglex = endPos.x - startPos.x;
        angley = endPos.y - startPos.y;
        //angle = Camera.main.ScreenToWorldPoint(new Vector3((Camera.main.nearClipPlane+10),endPos.y + 50f , endPos.x + 50f ));

    }

    void CalSpeed()
    {
        if (swipeTime > 0)
        {
            BallVelocity = swipeDistance / (swipeDistance - swipeTime);
        }
            

        BallSpeed = BallVelocity * 40;

        if (BallSpeed <= MaxBallSpeed)
        {
            if(BallSpeed >= 0)
            {
                BallSpeed = MaxBallSpeed;
            }
            else
            {
                BallSpeed = -MaxBallSpeed;
            }
            
        }
        swipeTime = 0;
    }

    public void FreezeAnauncer()
    {
        if(thrown == true)
        {
            Debug.Log("フリーズアナウンサー実行されました");
            IsFreezable = true;
        }
    }
}
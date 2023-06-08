using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameOverManager : MonoBehaviour
{
    private Vector3 playerCamPosition;

    private Quaternion playerCamRotation;

    [SerializeField]
    Camera tpsCam, playerCam;
    [SerializeField]
    PlayableDirector gameoverTimeline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SetCameraPosition();
            PlayTimeLine();
            
        }
    }

    public void PlayTimeLine()
    {
        gameoverTimeline.Play();




    }

    public void SetCameraPosition()
    {

        playerCamPosition = playerCam.GetComponent<Transform>().position;
        playerCamRotation = playerCam.GetComponent<Transform>().rotation;


        tpsCam.transform.position = playerCamPosition;
        tpsCam.transform.rotation = playerCamRotation;


    }
}

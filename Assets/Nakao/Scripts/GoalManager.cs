using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class GoalManager : MonoBehaviour
{
    [SerializeField]
    PlayableDirector endingtimeline;
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
            PlayTimeLine();
        }
    }

    public void PlayTimeLine()
    {
        endingtimeline.Play();

        


    }
}

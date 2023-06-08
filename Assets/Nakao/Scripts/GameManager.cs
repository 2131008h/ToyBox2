using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject fadeImage;
    // Start is called before the first frame update
    void Start()
    {
        fadeImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void StartTimeline(PlayableDirector TimelineName)
    {
        TimelineName.Play();
    }
 
}

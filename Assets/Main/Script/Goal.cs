using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class Goal : MonoBehaviour
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
            Invoke("LoadScene", 8.0f);
        }
    }

    public void PlayTimeLine()
    {
        endingtimeline.Play();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public string loadScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void ChangeScene()
    {
        SceneManager.LoadScene(loadScene);
    }


    public void ChangeSceneName(string NextScene)
    {
        loadScene = NextScene;
    }

}

  

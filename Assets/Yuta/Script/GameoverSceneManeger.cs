using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverSceneManeger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickSelectButton()
    {
        Invoke("LoadSelectStage", 1);
    }

    public void LoadSelectStage()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

    //
    public void ClickRestartButton()
    {
        Invoke("LoadGameScene", 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("First");
    }
}

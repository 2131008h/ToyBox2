using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneManager : MonoBehaviour
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

    //次のステージ作成後に使用
    public void ClickNextButton()
    {
        SceneManager.LoadScene("Scene");
    }
}

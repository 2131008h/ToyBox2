using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}

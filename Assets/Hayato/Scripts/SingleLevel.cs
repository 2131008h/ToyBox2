using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SingleLevel : MonoBehaviour
{
    public GameObject pauseUI1;
    public GameObject pauseUI2;
    public GameObject pauseUI3;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    private int currentStarsNum = 0;
    public int levelIndex;

    private void Start()
    {
        pauseUI1.SetActive(false);
        pauseUI2.SetActive(false);
        pauseUI3.SetActive(false);
    }

    public void BackButton()
    {
        SceneManager.LoadScene("SelectStage");
    }
    //public‚É“ü—Í‚µ‚½”Žš‚ªstarsNum‚É“ü—Í‚³‚ê‚é
    //test—p‚ÌScripts
    public void PressStarsButton(int _starsNum)
    {
        currentStarsNum = _starsNum;
        if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, _starsNum);
        }
        Debug.Log(PlayerPrefs.GetInt("Lv" + levelIndex));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Star1")
        {
            currentStarsNum += 1;
            pauseUI1.SetActive(true);
            Star1.SetActive(false);
            if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
            {
                PlayerPrefs.SetInt("Lv" + levelIndex, currentStarsNum);
            }
        }
        if (collision.gameObject.tag == "Star2")
        {
            currentStarsNum += 1;
            pauseUI2.SetActive(true);
            Star2.SetActive(false);
            if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
            {
                PlayerPrefs.SetInt("Lv" + levelIndex, currentStarsNum);
            }
        }
        if (collision.gameObject.tag == "Star3")
        {
            currentStarsNum += 1;
            pauseUI3.SetActive(true);
            Star3.SetActive(false); 
            if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
            {
                PlayerPrefs.SetInt("Lv" + levelIndex, currentStarsNum);
            }
        }
        if (collision.gameObject.tag == "A")
        {
            SceneManager.LoadScene("SelectStage");
        }
        Debug.Log(currentStarsNum);
    }

}

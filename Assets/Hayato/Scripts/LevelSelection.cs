using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] private bool unlocked;
    public Image unlockedImage;
    public GameObject[] stars;
    public Sprite starSprite;

    private void Update()
    {
        UpdateLevelImage();
        UpdateLevelStatus();
    }
    private void UpdateLevelStatus()
    {
        //ローカル変数の設定
        //アタッチしているGameObjectの名前を数字にする必要あり
        //ローカル変数 =（アタッチしているGameObjectの名前の数字）-1
        int PreviousLevelNum = int.Parse(gameObject.name) - 1;
        //データのロードを行う
        //星の数が1以上であれば次のステージを開放
        if (PlayerPrefs.GetInt("Lv" + PreviousLevelNum) > 0)
        {
            unlocked = true;
        }
    }

    private void UpdateLevelImage()
    {
        //アンロックされていないならステージの選択覧を表示をしない
        if (!unlocked)
        {
            unlockedImage.gameObject.SetActive(true);
            //star[].gameObject.SetActive(false);
            for(int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(false);
            }
            
        }
        //ステージが解放されているなら
        else
        {
            unlockedImage.gameObject.SetActive(false);
            //star[].gameObject.SetActive(true);
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].gameObject.SetActive(true);
            }
            for(int i = 0; i < PlayerPrefs.GetInt("Lv" + gameObject.name); i++)
            {
                stars[i].gameObject.GetComponent<Image>().sprite = starSprite;
            }
        }
    }
    //ボタンを押すとpublicで入力した名前のシーンへ移る
    public void PressSelection(string _LevelName)
    {
        if (unlocked)
        {
            SceneManager.LoadScene(_LevelName);
        }
    }
    
}

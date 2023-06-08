using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
public class CamerChanger : MonoBehaviour
{
    //画面遷移ボタンを押すとカメラの位置が変わるようにする。
    [SerializeField]
    PlayableDirector cameratimeline;
    [SerializeField]
    GameObject itemSlot;
    [SerializeField]
    GameObject goButton;

    private GameObject[] stopObject = new GameObject[default];
    private void Start()
    {
        
    }



    private RigidbodyConstraints rigid;
    public void PlayTimeLine()
    {
        cameratimeline.Play();

        itemSlot.SetActive(false);

        goButton.SetActive(false);

       
    }

    
}

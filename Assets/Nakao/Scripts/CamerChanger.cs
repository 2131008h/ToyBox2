using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
public class CamerChanger : MonoBehaviour
{
    //��ʑJ�ڃ{�^���������ƃJ�����̈ʒu���ς��悤�ɂ���B
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

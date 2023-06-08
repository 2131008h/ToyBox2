using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class ButtonGimmick : MonoBehaviour
{
    public PlayableDirector Button;
    public PlayableDirector Shelf;
    public static bool IsButtonGimmickfinished;

    private void Start()
    {
        Button = GetComponent<PlayableDirector>();
        IsButtonGimmickfinished = false;   
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&&IsButtonGimmickfinished==false)
        {
           PlayTimelineButton();    
        }
    }
    void PlayTimelineButton()
    {
            Button.Play();
            Shelf.Play();
            IsButtonGimmickfinished = true;   
    }
    //�ꎞ��~����
    void PauseTimeline()
    {
        Button.Pause();
    }
    //�ꎞ��~���ĊJ����
    void ResumeTimeline()
    {
        Button.Resume();
    }
    //��~����
    void StopTimeline()
    {
        Button.Stop();
    }
}

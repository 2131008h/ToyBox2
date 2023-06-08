using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TreasureGimmick : MonoBehaviour
{
    public PlayableDirector Treasure;
    bool IsTreasureGimmickfinished;
    
    void Start()
    {
        IsTreasureGimmickfinished = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"&& ButtonGimmick.IsButtonGimmickfinished==true&&IsTreasureGimmickfinished==false)
        {
            PlayTimelineTreasure();
        }
    }
    void PlayTimelineTreasure()
    {
        Treasure.Play();
        IsTreasureGimmickfinished = true;
    }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseManager : MonoBehaviour
{
    public GameObject posePanell;
    private bool isPosed = false;
    // Start is called before the first frame update
    public void OnClickPose()
    {
        if(isPosed == false)
        {
            posePanell.SetActive(true);
            isPosed = true;
        }
        
    }

    public void OnClickX_Continue()
    {
        if(isPosed == true)
        {
            posePanell.SetActive(false);
            isPosed = false;

        }
    }

    public void OnClickGiveUp()
    {
        //シーン繊維のスクリプトを書く
    }
}

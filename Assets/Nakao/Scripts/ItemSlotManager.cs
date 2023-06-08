using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotManager : MonoBehaviour
{

    public Animator itemSlot;

    public bool isisOpen = true;
    // Start is called before the first frame update
    public void OnClickedButton()
    {
        if(isisOpen == true)
        {
            itemSlot.SetBool("isOpen", true);
            isisOpen = false;
        }
        else
        {
            itemSlot.SetBool("isOpen", false);
            isisOpen = true;
        }
        
        
    }
}

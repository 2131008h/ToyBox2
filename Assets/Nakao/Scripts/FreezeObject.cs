using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ItemThrower.instance.IsFreezable);
        if(ItemThrower.instance.IsFreezable == true)   //��������ɕς��Ă������̃t���O
        {
            Debug.Log("freeze���Ă������Ă��[");
            Invoke("ItemFreeze", 5f);
        } 
    }

    private Rigidbody freezeitem;

    public void ItemFreeze()
    {
        freezeitem = this.gameObject.GetComponent<Rigidbody>();

        freezeitem.constraints = RigidbodyConstraints.FreezeAll;

        freezeitem.isKinematic = true;
    }

}

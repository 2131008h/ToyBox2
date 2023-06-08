using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChanger : MonoBehaviour
{
    public static ItemChanger instance;

    private void Awake()
    {
        instance = this;
    }


    public GameObject[] throwItem = new GameObject[default];

    public GameObject[] ItemImage = new GameObject[default];
 
    private GameObject myItem;
    private GameObject myImage;

    public GameObject grabItem;
    public void Mynumber(int num)
    {
        myItem = throwItem[num];
        myImage = ItemImage[num];
    }

    public void ChangeItem()
    {
        foreach(GameObject i in throwItem)
        {
            if(i.tag == "Player")
            {
                GameObject Item = i;

                Item.SetActive(false);
            }
            
            
            
        }
        myItem.SetActive(true);

    }

    public GameObject ObjectChecker()
    {
        foreach(GameObject i in throwItem)
        {
            if (i.tag == "Player" && i.activeSelf == true)
            {
                
                grabItem = i;

                return grabItem;
            }
          

            

        }

        return null;
    }






























    /*GameObject beforeItem;

    GameObject changeItem;


    [SerializeField]
    ItemDatabase ItemDatabase;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyNumber(int num)
    {
        Debug.Log(num);
        changeItem = ItemDatabase.GetList()[num].itemObject;
    }

    public void ChangeItem()
    {
        if(beforeItem == null)
        {
            changeItem.SetActive(true);
        }
        else if (beforeItem != null)
        {
           for(int i = 0; i <= ItemDatabase.GetList().Count; i++)
            {
                beforeItem = ItemDatabase.GetList()[i].itemObject;
                beforeItem.SetActive(false);
            }

            changeItem.SetActive(true);
        }
    }*/
}

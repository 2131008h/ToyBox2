using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ItemDatabase : ScriptableObject
{

    /*public static ItemDatabase instance;

    private void Awake()
    {
        instance = this;
    }*/
    public List<ThrownItem> itemList = new List<ThrownItem>();


    public List<ThrownItem> GetList()
    {
        return itemList;
    }
    
}

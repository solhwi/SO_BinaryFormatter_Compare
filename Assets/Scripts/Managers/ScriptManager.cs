using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager
{
    ItemListSO itemList;
    ItemListBinarySO itemListBinary;

    public ItemListSO ItemList
    {
        get
        {
            if(itemList == null)
            {
                
            }

            itemList = Managers.Resources.LoadSO<ItemListSO>("ItemListSO");
            return itemList;
        }
    }
    public ItemListBinarySO ItemListBinary
    {
        get
        {
            if(itemListBinary == null)
            {
                itemListBinary = Managers.Resources.LoadSO<ItemListBinarySO>("ItemListBinary");
            }

            string data = Managers.Resources.LoadBinary("ItemListBinary.txt");
            itemListBinary.MakeItemList(data);
            return itemListBinary;
        }
    }
}

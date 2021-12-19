using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager
{
    ItemListSO itemList;
    ItemListBinary itemListBinary;

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
    public ItemListBinary ItemListBinary
    {
        get
        {
            if(itemListBinary == null)
            {
                itemListBinary = Managers.Resources.LoadSO<ItemListBinary>("ItemListBinary");
            }

            itemListBinary.itemList = Managers.Resources.LoadBinary<ItemList>("ItemListBinary.txt");
            return itemListBinary;
        }
    }
}

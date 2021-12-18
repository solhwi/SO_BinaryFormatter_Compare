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
            itemList = itemList ?? itemList;

            itemList = Managers.Resources.LoadSO<ItemListSO>("ItemListSO");
            return itemList;
        }
    }
    public ItemListBinary ItemListBinary
    {
        get
        {

            itemListBinary = itemListBinary ?? Managers.Resources.LoadSO<ItemListBinary>("ItemListBinary");


            itemListBinary.itemList = Managers.Resources.LoadBinary<ItemList>("ItemListBinary.txt");
            return itemListBinary;
        }
    }
}

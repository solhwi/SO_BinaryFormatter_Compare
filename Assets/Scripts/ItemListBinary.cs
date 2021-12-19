using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

[CreateAssetMenu(fileName = "ItemListBinary", menuName = "SO/ItemListBinary")]
public class ItemListBinary : ScriptParser
{
    public ItemList itemList;

    public ItemList.TempInfo GetInfo(int idx) => itemList.GetInfo(idx);
    public bool Init()
    {
        ItemList list = Parser<ItemList>("Datas/ItemList");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = new FileStream($"{Application.dataPath}/AssetBundles/Binary/ItemListBinary.txt", FileMode.Create);
        formatter.Serialize(fs, list);

        fs.Close();

        return !list.IsVaild;
    }

}

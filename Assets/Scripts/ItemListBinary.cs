using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

[CreateAssetMenu(fileName = "ItemListBinary", menuName = "SO/ItemListBinary")]
public class ItemListBinarySO : ScriptParser
{
    public ItemList itemList;

    public ItemList.TempInfo GetInfo(int idx) => itemList.GetInfo(idx);
    public bool Init()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        
        string data = File.ReadAllText($"{Application.dataPath}/Resources/Datas/ItemList.json", Encoding.UTF8);
        byte[] binaryData = Encoding.UTF8.GetBytes(data);

        using (FileStream fs = new FileStream($"{Application.dataPath}/AssetBundles/Binary/ItemListBinary.txt", FileMode.Create))
        {
            formatter.Serialize(fs, binaryData);
            fs.Close();
        }

        return binaryData.Length > 0;
    }

    public void MakeItemList(string data)
    {
        Debug.Log(data.Length);     
    }

}

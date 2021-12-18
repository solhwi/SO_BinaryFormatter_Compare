using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class ResourceManager
{
    public T LoadSO<T>(string path) where T : ScriptableObject
    {
        return Resources.Load<T>($"AssetBundles/SO/{path}");
    }

    public T LoadBinary<T>(string path) where T : class
    {
        FileStream fs = new FileStream($"{Application.dataPath}/Resources/AssetBundles/Binary/{path}", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();

        T data = formatter.Deserialize(fs) as T;

        fs.Close();

        return data;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine.Networking;

public class ResourceManager
{
    public AssetBundle bundle { get; set; }

    public void Init()
    {

    }

    public T LoadSO<T>(string path) where T : ScriptableObject
    {
        return bundle.LoadAsset<T>($"{path}");
        //return Resources.Load<T>($"{path}");
    }

    public T LoadBinary<T>(string path) where T : class
    {
        FileStream fs = new FileStream($"{Application.dataPath}/AssetBundles/Binary/{path}", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();

        T data = formatter.Deserialize(fs) as T;

        fs.Close();

        return data;
    }
}

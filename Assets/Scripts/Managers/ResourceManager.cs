using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine.Networking;
using System.Text;

public class ResourceManager
{
    public AssetBundle bundle { get; set; }

    public T LoadSO<T>(string path) where T : ScriptableObject
    {
        return bundle.LoadAsset<T>($"{path}");
    }

    public string LoadBinary(string path)
    { 
        string fullPath = $"{Application.dataPath}/AssetBundles/Binary/{path}";

        byte[] binaryData = File.ReadAllBytes(fullPath);
        string data = Encoding.UTF8.GetString(binaryData);

        return data;
    }
}



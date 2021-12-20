using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameStarter : MonoBehaviour
{
    public void SOLoadTimeTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            var info = Managers.Scripts.ItemList?.GetInfo(i);
            Debug.Log(info?.itemName);
        }
    }

    public void BinaryLoadTimeTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            var info = Managers.Scripts.ItemListBinary.GetInfo(i);
            Debug.Log(info?.itemName);
        }
    }

    public void LoadAssetBundle()
    {
        StartCoroutine(LoadCoroutine());
    }

    IEnumerator LoadCoroutine()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("C:/ScriptParse/Assets/AssetBundles/manifest");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Managers.Resources.bundle = DownloadHandlerAssetBundle.GetContent(www);
        }
    }
}

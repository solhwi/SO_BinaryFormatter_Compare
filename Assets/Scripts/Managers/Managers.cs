using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Managers : Singleton<Managers>
{
    ScriptManager scripts = new ScriptManager();
    ResourceManager resources = new ResourceManager();

    public static ScriptManager Scripts 
    {
        get 
        {
            return Instance.scripts; // instance�� �����Ѵٸ� scripts�� ��ȯ, �װ� �ƴ϶�� �ʱ�ȭ �� ��ȯ�մϴ�.
        } 
    }

    public static ResourceManager Resources
    {
        get
        {
            if(Instance.resources.bundle == null)
            {
                 
            }

            return Instance.resources;
        }
    }

    IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle("C:/ScriptParse/Assets/AssetBundles/manifest");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            resources.bundle = DownloadHandlerAssetBundle.GetContent(www);
        }
    }
}

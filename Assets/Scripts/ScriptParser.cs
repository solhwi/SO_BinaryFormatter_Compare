using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParser : ScriptableObject 
{
    public virtual T Parser<T>(string scriptPath) where T : class
    {
        TextAsset data = Resources.Load<TextAsset>(scriptPath);
        T list = JsonUtility.FromJson<T>(data.ToString());

        return list;
    }
}



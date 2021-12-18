using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null) Init();

            return instance;
        }
    }

    protected void Awake()
    {
        Init();
    }

    private static void Init()
    {
        if (instance == null)
        {
            GameObject g = GameObject.FindGameObjectWithTag("Managers"); // 매니저를 찾아옵니다.
            instance = g?.GetOrAddComponent<T>();

            DontDestroyOnLoad(g);
        }
    }
}

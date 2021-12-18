using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : Singleton<Managers>
{
    ScriptManager scripts = new ScriptManager();
    ResourceManager resources = new ResourceManager();

    public static ScriptManager Scripts 
    {
        get 
        {
            return Instance.scripts; // instance가 존재한다면 scripts를 반환, 그게 아니라면 초기화 후 반환합니다.
        } 
    }

    public static ResourceManager Resources
    {
        get
        {
            return Instance.resources;
        }
    }
}

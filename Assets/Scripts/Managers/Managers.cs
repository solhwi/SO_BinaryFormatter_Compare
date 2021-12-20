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
            return Instance.scripts;
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


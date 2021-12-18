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
            return Instance.scripts; // instance�� �����Ѵٸ� scripts�� ��ȯ, �װ� �ƴ϶�� �ʱ�ȭ �� ��ȯ�մϴ�.
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

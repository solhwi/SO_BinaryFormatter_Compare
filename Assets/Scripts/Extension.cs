using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Extension
{
    public static T GetOrAddComponent<T>(this GameObject g) where T : UnityEngine.Component => g?.GetComponent<T>() ?? g?.AddComponent<T>(); 
}

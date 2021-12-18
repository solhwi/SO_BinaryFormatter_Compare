using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public void SOLoadTimeTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            var info = Managers.Scripts.ItemList.GetInfo(i);
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

    IEnumerator LoadCoroutine()
    {
        yield return null;
    }
}

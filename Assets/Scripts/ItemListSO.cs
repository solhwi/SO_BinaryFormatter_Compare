using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// �� ���� ���� ���鿡 ���� Scriptable Object���� ����մϴ�.
/// </summary>
/// 

[System.Serializable]
public class ItemList
{
    [System.Serializable]
    public class TempInfo
    {
        public int itemIdx;
        public int itemLevel;
        public string itemName;
        public string category;
    }

    [SerializeField] List<TempInfo> tempInfoList;

    public TempInfo GetInfo(int idx)
    {
        if (idx < tempInfoList.Count)
        {
            return tempInfoList[idx];
        }

        return null;
    }

    public bool IsVaild
    {
        get { return tempInfoList.Count <= 0; }
    }
}

[CreateAssetMenu(fileName = "ItemListSO", menuName = "SO/ItemListSO")]
public class ItemListSO : ScriptParser
{
    [SerializeField] ItemList itemList;

    public ItemList.TempInfo GetInfo(int idx) => itemList.GetInfo(idx);
    public bool Init()
    {
        itemList = Parser<ItemList>("Datas/ItemList");

        return !itemList.IsVaild;
    }

    public override T Parser<T>(string scriptPath)
    {
        return base.Parser<T>(scriptPath);
    }
}
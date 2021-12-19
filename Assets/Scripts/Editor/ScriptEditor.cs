using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ItemListSO))]
public class ItemListEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ItemListSO itemListSO = target as ItemListSO;

        if (GUILayout.Button("Json To SO"))
        {
            Debug.Log("Json to SO");
            
            if(!itemListSO.Init())
            {
                Debug.LogError("�Ľ��� ����� �̷������ �ʾҽ��ϴ�.");
            }
        }
    }
}

[CustomEditor(typeof(ItemListBinary))]
public class BinaryParserEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ItemListBinary binaryParser = target as ItemListBinary;

        if (GUILayout.Button("Json To Binary"))
        {
            Debug.Log("Json to Binary");

            if (!binaryParser.Init())
            {
                Debug.LogError("�Ľ��� ����� �̷������ �ʾҽ��ϴ�.");
            }
        }
    }
}
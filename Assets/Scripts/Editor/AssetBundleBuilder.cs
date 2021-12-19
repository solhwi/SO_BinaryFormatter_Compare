using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class AssetBundleBuilder
{
    [MenuItem("Assets/Build AssetBundle")]

    public static void ExportResource()
    {
        string path = Path.Combine("Assets/AssetBundles");

        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}

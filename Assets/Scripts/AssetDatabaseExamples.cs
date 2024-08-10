using UnityEditor;
using UnityEngine;

public class AssetDatabaseExamples : MonoBehaviour
{
    [MenuItem("AssetDatabase/Import Package Example")]
    static void ImportPackageExample()
    {
        var texturePackageNames = new[] {"Assets/Scripts/Feel.unitypackage"};
        foreach (var package in texturePackageNames)
        {
            AssetDatabase.ImportPackage(package, false);
        }
    }
}
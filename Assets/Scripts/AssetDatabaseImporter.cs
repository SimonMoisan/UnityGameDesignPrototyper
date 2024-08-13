using UnityEditor;
using UnityEngine;
using System.IO;

public class AssetDatabaseImporter : MonoBehaviour
{
    [MenuItem("AssetDatabase/Import Unity Packages")]
    static void ImportPackageExample()
    {
        string json = File.ReadAllText("PackagesToIntegrate.json");
        
        FilePathList filePathList = JsonUtility.FromJson<FilePathList>(json);
        
        string[] paths = filePathList.filePaths;

        foreach (var package in paths)
        {
            Debug.Log(package);
            AssetDatabase.ImportPackage(package, false);
        }
    }
}

[System.Serializable]
public class FilePathList
{
    public string[] filePaths;
}
using UnityEngine;
using System.IO;

/// <summary>
/// 文件读写工具
/// </summary>
public static class FileHelper
{
    static StreamWriter writer = null;
    static StreamReader reader = null;

    /// <summary>
    /// 保存本地文件
    /// </summary>
    /// <param name="fileName">文件名</param>
    /// <param name="fileContent">文件内容</param>
    public static bool Save(string dirName, string fileName, string fileContent)
    {
        string dirPath = Application.persistentDataPath + "/" + dirName;
        if (!Directory.Exists(dirPath))
            Directory.CreateDirectory(dirPath);
        string filePath = dirPath + "/" + fileName;
        if (File.Exists(filePath))
            File.Delete(filePath);
        writer = File.CreateText(filePath);
        writer.Write(fileContent);
        writer.Close();
        writer.Dispose();
        Debug.Log("文件保存成功!" + filePath);
        return true;
    }

    /// <summary>
    /// 读取本地文件
    /// </summary>
    /// <param name="fileName">文件名</param>
    /// <returns></returns>
    public static string Load(string dirName, string fileName)
    {
        string fileContent = string.Empty;
        string dirPath = Application.persistentDataPath + "/" + dirName;
        if (!Directory.Exists(dirPath))
        {
            Debug.LogWarning("目录不存在!" + dirPath);
            return fileContent;
        }
        string filePath = dirPath + "/" + fileName;
        if (!File.Exists(filePath))
        {
            Debug.LogWarning("文件不存在!" + filePath);
            return fileContent;
        }
        reader = File.OpenText(filePath);
        fileContent = reader.ReadToEnd();
        reader.Close();
        reader.Dispose();
        return fileContent;
    }

}

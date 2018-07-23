using System.Collections.Generic;
using UnityEngine;
using System.Text;

/// <summary>
/// 日志打印工具
/// </summary>
public static class LogHelper
{
    static StringBuilder builder = new StringBuilder();

    /// <summary>
    /// 打印字典数据
    /// </summary>
    /// <typeparam name="K">泛型Key</typeparam>
    /// <typeparam name="V">泛型Value</typeparam>
    /// <param name="data">字典数据</param>
    public static void Dump<K,V>(Dictionary<K,V> data)
    {
        builder.Length = 0;
        foreach (KeyValuePair<K,V> pair in data)
        {
            builder.AppendLine(pair.Key + ":" + pair.Value);
        }
        Debug.Log(builder);
        builder.Length = 0;
    }
}

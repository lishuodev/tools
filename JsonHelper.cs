using Newtonsoft.Json;

/// <summary>
/// Json序列化工具
/// </summary>
public static class JsonHelper
{
    /// <summary>
    /// 反序列化(泛型)
    /// </summary>
    /// <typeparam name="T">数据类型</typeparam>
    /// <param name="s">反序列化前的数据</param>
    /// <returns>反序列化后的数据</returns>
    public static T FromJson<T>(string s)
    {
        return JsonConvert.DeserializeObject<T>(s);
    }

    /// <summary>
    /// 序列化(泛型)
    /// </summary>
    /// <typeparam name="T">数据类型</typeparam>
    /// <param name="data">序列化前的数据</param>
    /// <returns>序列化后的数据</returns>
    public static string ToJson<T>(T data)
    {
        return JsonConvert.SerializeObject(data);
    }
}
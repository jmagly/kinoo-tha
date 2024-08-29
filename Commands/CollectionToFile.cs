namespace Kinoo.THA.Commands;

using Newtonsoft.Json;
using System.Collections.Generic;

/// <summary>
/// Handles conversion of a collection to a JSON file.
/// </summary>
public class CollectionToFile
{
    /// <summary>
    /// Converts a collection to a JSON file.
    /// </summary>
    /// <typeparam name="T">Model type being converted</typeparam>
    /// <param name="collection">data collection</param>
    /// <param name="filePath">output file path</param>
    public void CollectionToJson<T>(IEnumerable<T> collection, string filePath)
    {
        string json = JsonConvert.SerializeObject(collection, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}

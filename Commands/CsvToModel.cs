namespace Kinoo.THA.Commands;

using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

/// <summary>
/// Handles Conversioin of CSV to Model instance.
/// </summary>
/// <typeparam name="T">output type</typeparam>
public class CsvToModel<T>
{
    /// <summary>
    /// Converts CSV file to Model instance.
    /// </summary>
    /// <param name="filePath">location of CSV file</param>
    /// <returns>de-serilaized model instance</returns>
    public IEnumerable<T> ConvertCsvToModel(string filePath)
    {   
        using var reader = new StreamReader(filePath);
        // CsvReader is a third-party library that reads CSV and maps the values to a model based on decorators.
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        return csv.GetRecords<T>().ToList(); // Exiting a using we need to call ToList() to materialize the IEnumerable.
    }
}
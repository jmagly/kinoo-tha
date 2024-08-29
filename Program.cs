namespace Kinoo.THA;

using Commands;
using Models;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a file path.");
            return;
        }

        if (args.Length == 1)
        {
            Console.WriteLine("Both an input file path and an output file pate are required.");
            return;
        }

        var inputFilePath = args[0];
        var outputFilePath = args[1];

        var csvToModel = new CsvToModel<WandEvent>();
        var wandEvents = csvToModel.ConvertCsvToModel(inputFilePath);

        var collectionToFile = new CollectionToFile();
        collectionToFile.CollectionToJson(wandEvents, outputFilePath);

        Console.WriteLine("Conversion complete.");
    }
}

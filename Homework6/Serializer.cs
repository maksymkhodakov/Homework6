using System.Text.Json;

namespace Homework6;

public class Serializer<T> : ISerializationExecutor<T>
{
    public void Execute(string path, List<T> data, JsonSerializerOptions options)
    {
        var jsonString = JsonSerializer.Serialize(data, options);
        using var outputFile = new StreamWriter(path);
        outputFile.WriteLine(jsonString);
    }
}
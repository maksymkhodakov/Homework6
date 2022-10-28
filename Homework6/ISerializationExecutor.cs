using System.Text.Json;

namespace Homework6;

public interface ISerializationExecutor<T>
{
    void Execute(string path, List<T> data, JsonSerializerOptions options);
}
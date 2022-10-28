namespace Homework6;

// main interface for executing deserialization
public interface IDeserializationExecutor<T>
{
    void Execute(string path);
}
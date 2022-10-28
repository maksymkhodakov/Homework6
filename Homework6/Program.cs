using System.Text.Json;

namespace Homework6;

public static class Program
{
    static void Main(string[] args)
    {
        const string deserializationPath = "/Users/maksymkhodakov/Desktop/test.json";
        const string serializationPath = "/Users/maksymkhodakov/Desktop/test1.json";
        
        /*var deserializer = new Deserializer<Book>();
        deserializer.Execute(deserializationPath);*/


        var serializer = new Serializer<Book>();
        var book = new Book(1, "test", new PublishingHouse(1, "name", "Kyiv"));
        var data = new List<Book> { book };
        serializer.Execute(serializationPath, data, new JsonSerializerOptions(){ PropertyNameCaseInsensitive = true });
    }
}
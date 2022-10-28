using System.Text.Json;

namespace Homework6;

public class Deserializer<T> : IDeserializationExecutor<T>
{
    public void Execute(string path)
    {
        using var r = new StreamReader(path);
        var json = r.ReadToEnd();
        var data = JsonSerializer.Deserialize<List<T>>(json);
        if (data is List<Book> list)
            GetBooksInfo(list);
        else data?.ForEach(el =>Console.WriteLine(el)); // tempo solution
    }

    private static void GetBooksInfo(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine("Title: " + book.Title + "\n"
                              + "Publishing house Id: " + book.PublishingHouseId +
                              "\nPublishingHouseInfo:\t" + book.PublishingHouse.Id +
                              " " + book.PublishingHouse.Name + " "
                              + book.PublishingHouse.Address + "\n\n");
        }
    }
}
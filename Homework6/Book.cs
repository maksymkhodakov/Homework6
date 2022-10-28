using System.Text.Json.Serialization;

namespace Homework6;

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }
    [JsonPropertyName("Name")]
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }

    public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
    {
        PublishingHouseId = publishingHouseId;
        Title = title;
        PublishingHouse = publishingHouse;
    }
}
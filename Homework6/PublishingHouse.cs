namespace Homework6;

public class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; init; }
    public string Address { get; set; }

    public PublishingHouse(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}
public class Event
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public decimal Price { get; set; }

    public Event(int id, string name, string description, DateTime date, string location, decimal price)
    {
        ID = id;
        Name = name;
        Description = description;
        Date = date;
        Location = location;
        Price = price;
    }
}
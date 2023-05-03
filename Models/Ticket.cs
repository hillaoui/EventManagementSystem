public class Ticket
{
    public int ID { get; set; }
    public int EventID { get; set; }
    public int UserID { get; set; }
    public decimal PricePaid { get; set; }

    public Ticket(int id, int eventId, int userId, decimal pricePaid)
    {
        ID = id;
        EventID = eventId;
        UserID = userId;
        PricePaid = pricePaid;
    }
}

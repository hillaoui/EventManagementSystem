using System;
using System.Collections.Generic;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public ICollection<Ticket> Tickets { get; set; }
}
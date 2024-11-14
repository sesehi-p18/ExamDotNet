using System;
using System.Collections.Generic;

public class Owner
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; }
}

public class Event
{
    public int Id { get; set; }
    public Owner Owner { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool Confirmed { get; set; }
    
    public static List<Event> InitEvents()
    {
        var events = new List<Event>
        {
            new Event
            {
                Id = 1,
                Owner = new Owner
                {
                    Firstname = "Inisan", 
                    Lastname = "Hervé", 
                    Email = "inisan.herve@example.com", 
                    IsAdmin = false
                },
                Label = "Meeting",
                Description = "Project meeting",
                StartDate = new DateTime(2024, 6, 5, 10, 0, 0),
                EndDate = new DateTime(2024, 6, 5, 12, 0, 0),
                Confirmed = true
            },
            new Event
            {
                Id = 2,
                Owner = new Owner
                {
                    Firstname = "Inisan", 
                    Lastname = "Hervé", 
                    Email = "inisan.herve@example.com", 
                    IsAdmin = false
                },
                Label = "Workshop",
                Description = "Development workshop",
                StartDate = new DateTime(2024, 6, 10, 9, 0, 0),
                EndDate = new DateTime(2024, 6, 10, 17, 0, 0),
                Confirmed = true
            },
            new Event
            {
                Id = 3,
                Owner = new Owner
                {
                    Firstname = "Emmet",
                    Lastname = "Brown",
                    Email = "emmet.brown@time-capsule.com",
                    IsAdmin = false
                },
                Label = "DeLorean Demo",
                Description = "Test DeLorean on Two Pines parking lot",
                StartDate = new DateTime(2024, 6, 1, 20, 0, 0),
                EndDate = new DateTime(2024, 6, 1, 22, 30, 0),
                Confirmed = true
            },
            new Event
            {
                Id = 4,
                Owner = new Owner
                {
                    Firstname = "Inisan", 
                    Lastname = "Hervé", 
                    Email = "inisan.herve@example.com", 
                    IsAdmin = false
                },
                Label = "Conference",
                Description = "Tech conference",
                StartDate = new DateTime(2024, 6, 15, 9, 0, 0),
                EndDate = new DateTime(2024, 6, 15, 17, 0, 0),
                Confirmed = false
            },
            new Event
            {
                Id = 5,
                Owner = new Owner
                {
                    Firstname = "John", 
                    Lastname = "Doe", 
                    Email = "john.doe@example.com", 
                    IsAdmin = false
                },
                Label = "Social Event",
                Description = "Networking event",
                StartDate = new DateTime(2024, 7, 1, 18, 0, 0),
                EndDate = new DateTime(2024, 7, 1, 21, 0, 0),
                Confirmed = true
            }
        };
        return events;
    }
    
    
}


    

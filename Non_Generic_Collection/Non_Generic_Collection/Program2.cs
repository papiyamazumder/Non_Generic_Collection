using System;
using System.Collections;

class Event               // using 2 list
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Type { get; private set; }
    public DateTime EventDate { get; private set; }
    public int TotalCount { get; private set; }

    public Event(int id, string name, string type, DateTime eventdate, int totalcount)
    {
        Id = id;
        Name = name;
        Type = type;
        EventDate = eventdate;
        TotalCount = totalcount;
    }
}

internal class Program2
{
    public static ArrayList AddEvent()
    {
        ArrayList EventObjList = new ArrayList();

        Event obj = new Event(1, "A", "Sports", DateTime.Now, 100);
        EventObjList.Add(obj);

        obj = new Event(2, "B", "Conference", DateTime.Now, 200);
        EventObjList.Add(obj);

        obj = new Event(3, "C", "Bday", DateTime.Now, 300);
        EventObjList.Add(obj);

        obj = new Event(4, "D", "Seminar", DateTime.Now, 400);
        EventObjList.Add(obj);

        obj = new Event(5, "E", "DJ", DateTime.Now, 500);
        EventObjList.Add(obj);

        return EventObjList;
    }

    private static void Main(string[] args)
    {
        ArrayList list = AddEvent();

        foreach (Event item in list)
        {
            if (item.Type == "Bday")
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Type: {item.Type}, Event Date: {item.EventDate}, Total Count: {item.TotalCount}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        // OR       // Direct usage without assigning to a variable-

        foreach (Event item in AddEvent())          // If you need the list again, you'd have to call AddEvent() again
        {
            if (item.Type == "Bday")
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Type: {item.Type}, Event Date: {item.EventDate}, Total Count: {item.TotalCount}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

    }
}

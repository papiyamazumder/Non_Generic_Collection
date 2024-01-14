//using System.Collections;
//using System.Xml.Linq;

//class Event               // using bool
//{
//    public int Id { get; private set; }
//    public string Name { get; private set; }
//    public string Type { get; private set; }
//    public DateTime EventDate { get; private set; }
//    public int TotalCount { get; private set; }

//    public Event(int id, string name, string type, DateTime eventdate, int totalcount)
//    {
//        Id = id;
//        Name = name;
//        Type = type;
//        EventDate = eventdate;
//        TotalCount = totalcount;
//    }
//}
//internal class Program4
//{
//    public static ArrayList AddEvent()
//    {
//        ArrayList EventObjList = new ArrayList();

//        Event obj = new Event(1, "A", "Sports", DateTime.Now, 100);
//        EventObjList.Add(obj);

//        obj = new Event(2, "B", "Conference", DateTime.Now, 200);
//        EventObjList.Add(obj);

//        obj = new Event(3, "C", "Bday", DateTime.Now, 300);
//        EventObjList.Add(obj);

//        obj = new Event(4, "D", "Seminar", DateTime.Now, 400);
//        EventObjList.Add(obj);

//        obj = new Event(5, "E", "DJ", DateTime.Now, 500);
//        EventObjList.Add(obj);

//        return EventObjList;
//    }

//    public static void DisplayEventsByType(string type, ArrayList eventList)
//    {
//        bool found = false;

//        foreach (Event eventObj in eventList)
//        {
//            if (eventObj.Type == type)
//            {
//                Console.WriteLine($"ID: {eventObj.Id}, Name: {eventObj.Name}, Type: {eventObj.Type}, Event Date: {eventObj.EventDate}, Total Count: {eventObj.TotalCount}");
//                found = true;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine("Not Found");
//        }
//    }

//    private static void Main(string[] args)
//    {
//        ArrayList EventObjList = AddEvent();

//        Console.WriteLine("Searching for events of type 'Bday':");
//        DisplayEventsByType("Bday", EventObjList);
//    }
//}
//using System.Collections;
//using System.Xml.Linq;

//class Event         // using Dipannita- 3 list
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
//internal class Program3
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

//    public static ArrayList GetEventsByType(string type, ArrayList EventObjList)      // creating function of arraylist display events
//    {
//        ArrayList displayevents = new ArrayList();

//        foreach (Event obj in EventObjList)
//        {
//            if (obj.Type == type)
//            {
//                displayevents.Add(obj);
//                Console.WriteLine($"{obj.Name} of {obj.Type} is Found");
//            }
//            else
//            {
//                Console.WriteLine("Not Found");
//            }
//        }
//        Console.WriteLine("");

//        return displayevents;
//    }

//    private static void Main(string[] args)
//    {

//        ArrayList EventObjList = AddEvent();

//        ArrayList output = GetEventsByType("Bday", EventObjList);

//        foreach (Event item in output)
//        {
//            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Type: {item.Type}, Event Date: {item.EventDate}, Total Count: {item.TotalCount}");
//        }

//    }
//}

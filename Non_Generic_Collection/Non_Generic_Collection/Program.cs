//using System.Collections;
//using System.Xml.Linq;

//class Event           // using 1 list
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Type { get; set; }
//    public DateTime EventDate { get; set; }
//    public int TotalCount { get; set; }

//    public Event(int id, string name, string type, DateTime eventdate, int totalcount)
//    {
//        Id = id;
//        Name = name;
//        Type = type;
//        EventDate = eventdate;
//        TotalCount = totalcount;
//    }
//}
//internal class Program
//{
//    public static ArrayList EventObjList = new ArrayList();

//    public static void AddEvent()
//    {
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
//    }

//    private static void Main(string[] args)
//    {
//        AddEvent();

//        foreach (Event item in EventObjList)
//        {
//            if (item.Type == "Bday")
//            {
//                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Type: {item.Type}, Event Date: {item.EventDate}, Total Count: {item.TotalCount}");
//            }
//            else
//            {
//                Console.WriteLine("Not Found");
//            }
//        }
//    }
//}

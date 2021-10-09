using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   /*
     Structures (struct): 
    Faster to process than classes
    useful for gamedev
    can have    : functions
                : fields
                : properties
                : indexers
                : op functions
                : events
                : defined constructors, not destructors
    Structs : can implement one or more interfaces, but can't inherit from other structs or classes
            : can't be used as a base for other structs or classes
            : members cant be specified as abstract, virtual or protected

    Enum type can be used to instantiate a list of named int constants; can be used via enum in namespaces, classes and structs
    */
    public struct WorldLocation
    {
        public string Locname { get; set; }
        public string Locdescription { get; set; }

        public WorldLocation(string name, string description)
        {
            this.Locname = name;
            this.Locdescription = description;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"{Locname}\n{Locdescription}");
        }
    }
    public struct DayOfYear
    { 
        public string DayName { get; set; }
        public string MonthName { get; set; }
        public string EraName { get; set; }
        public int YearNum { get; set; }
        public int DayNum { get; set; }
    }
    public struct TimeOfDay
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string AMorPM { get; set; }
        public string DayOrNight { get; set; }
    }

}

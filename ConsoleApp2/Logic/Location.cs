using System;

namespace ConsoleApp2
{
    //end test classes
    //classes can have: properties, access modifiers, constructors, functions, fields
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasExit { get; set; }
        public Location()
        {
            //testing
            Console.WriteLine("instantiated Location() from class");
        }
        public Location(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Location(bool hasExit)
        {
            HasExit = hasExit;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDesc()
        {
            return Description;
        }
    }
}

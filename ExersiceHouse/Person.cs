using System;

namespace ExersiceHouse
{
    class Person
    {
        public Person(string name, House house)
        {
            Name = name;
            House = house;
        }        
        public House House { get; set; }

        public string Name { get; set; }

        
        public void ShowData()
        {
            Console.WriteLine($"Name: {Name}");
            House.ShowData();
            House.Door.GetDoor();
        }
    }
}

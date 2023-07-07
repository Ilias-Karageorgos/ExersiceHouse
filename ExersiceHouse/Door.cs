using System;

namespace ExersiceHouse
{
    class Door
    {
       
        public Door(string color)
        {
            Color = color;
        }

        public string Color { get; set; }

        public void GetDoor()
        {
            Console.WriteLine($"I am door, my color is {Color}");
        }
    }
}

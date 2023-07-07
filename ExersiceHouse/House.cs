using System;

namespace ExersiceHouse
{
    class House
    {
        public int Area { get; set; }
        public Door Door { get; set; }

        public Person Person { get; set; }

        public House(int area)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am house, my area is {Area} m2");
        }

        public Door GetDoor()
        {
            return Door;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door d1 = new Door("Brown");

            SmallApartment sApart1 = new SmallApartment(d1);            

            Person p1 = new Person("ilias", sApart1);

            p1.ShowData();

        }
    }
}

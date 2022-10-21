using MemeHierarchy.CoffeeTime;
using MemeHierarchy.Date1;
using MemeHierarchy.Geometry;
using System;
using System.Collections.Generic;

namespace MemeHierarchy
{
    class Program
    {
        static CoffeeMachine CreateCoffee()
        {
            return new CoffeeMachine(1, false); // Ананимный экземпляр класса ( не имеет имени ) 
        }

        static void Main(string[] args)
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(10, 10);

            Rectangle rectangle = new Rectangle(point1, point2);

            Date date1 = new Date(2002, 10, 21);

            Date date2 = new Date(2003, 1, 24);



            Console.WriteLine(date1.CompareDate(date2));

            Console.WriteLine(date2.CompareDate(date1));



            while (true)
            {
                CreateCoffee();
            }
        }
    }
}


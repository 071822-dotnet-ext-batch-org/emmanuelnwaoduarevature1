using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly_Inheritance 
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
          Console.WriteLine("Please enter on seperate lines the car 'model', 'make', 'year', 'color', 'size e.g 4000', and 'cost e.g, 3000'");

          Console.WriteLine();
          
          //passed in the user car info into the Constructor Car_Description parameters
          string model = Console.ReadLine();
          string make = Console.ReadLine();
          string year = Console.ReadLine();
          string color = Console.ReadLine();
          int size = Int32.Parse(Console.ReadLine());
          int cost = Int32.Parse(Console.ReadLine());
          
          //instantiate an object from class Car_description
          Car_description b = new Car_description(model, make, year, color, size);

          //instantiated an object from the clas Car_other 
          Car_other  d = new Car_other();
          
         
          Console.WriteLine();
         
          //console printed the behavior to show the effect of field inheritance
          Console.WriteLine(b.Type());
          
          Console.WriteLine(d.Price(cost));
           
           Console.WriteLine();
           //console printed the behavior to show overiding and inheriting a method
           d.Size();
    }          
}
}

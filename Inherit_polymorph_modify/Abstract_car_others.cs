using System;

namespace Poly_Inheritance
{
    public abstract class Abstract_car_others
    {
        //Abstract hides the behaviour
         public abstract string Price(int cost); 


         //Polymorphism via override

         public virtual void Size(){
      
      Console.WriteLine ("By the ways, Hondas are said to be the safest cars on average.");

    }
    }
}

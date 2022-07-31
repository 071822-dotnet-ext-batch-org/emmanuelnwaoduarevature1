using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly_Inheritance
{
public class Car_other : Abstract_car_others{

public override void Size(){
      base.Size();
      Console.WriteLine("However, Toyotas are the most reliable cars on average.");

    }
       
public override string Price(int cost){

     string [] dimed = {"And the car is cheap", "And the car is expensive", "And the car is very pricey"};
     if( cost < 1000){
     return dimed[0];
     }
      if( cost < 10000){
     return dimed[1];
     }
     else{
      return dimed[2];
     }

    }

} 
} 
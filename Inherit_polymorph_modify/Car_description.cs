using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly_Inheritance
{
public class Car_description : Car{

string color;
int size;
public Car_description(string model, string make, string year, string color, int size): base(model, make, year){
 this.color = color;
 this.size = size;
}

   public string Type(int size){
     
    
       string [] dim = {"small.", "medium.", "big."};

      if ( size < 1999){
      
      return dim[0];

     } 
     else if ( size < 2999){

      return dim[1];

     } 
     else{

      return dim[2];
      
     } 
      
   }  
   public string Type(){

    return $"The model, make, year, color, and size of this car is {base.model}, {base.make}, {base.year}, {color}, and {Type(size)}";
   
   }

   
   
   
   

}

}

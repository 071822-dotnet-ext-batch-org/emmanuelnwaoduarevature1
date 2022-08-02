﻿using System;

namespace _5_OperatorsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
           //Increment once
           //int num = 2;
           //Console.WriteLine($"{Increment(num)}");

           //Decrement once
           //int num = 2;
           //Console.WriteLine($"{Decrement(num)}");

           //boolean
           bool input = false;
           Console.WriteLine($"{Not(input)}");

           //Negative number
            int num = 2;
           Console.WriteLine($"{Negate(num)}");
           
           //Sum number
        //    int num1 = 3;
        //    int num2 = 5;
        //    Console.WriteLine($"{Sum(num1, num2)}");

           //num diff
           
        //    int num1 = 10;
        //    int num2 = 2;
        //    Console.WriteLine($"{Diff(num1, num2)}");

           

           int num1 = 10;
           int num2 = 2;
           Console.WriteLine($"{Quotient(num1, num2)}");

        }

        /// <summary>
        /// This method takes an in and returns the int incremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Increment(int num)
        {
            //throw new NotImplementedException($"Increment() is not implemented yet.");
            return ++num;
        }

        /// <summary>
        /// This method takes an int and returns the int decremented once
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Decrement(int num)
        {
            //throw new NotImplementedException($"Decrement() is not implemented yet");
            return --num;
        }

        /// <summary>
        /// This method takes a boolean value and returns the opposite boolean value.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Not(bool input)
        {
            //throw new NotImplementedException($"Not() is not implemented yet");
            
            if(input == false){
                
            }
            return true;
        }  
        

        /// <summary>
        /// /// This method takes an int and returns the negative of that int.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Negate(int num)
        {
            //throw new NotImplementedException($"Negate() is not implemented yet");
            int x = num *-1;

            return x;

        }

        /// <summary>
        /// This method takes two ints and returns the sum
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Sum(int num1, int num2)
        {
            //throw new NotImplementedException($"Sum() is not implemented yet");

            int Y = num1 + num2;

            return Y;
        }

        /// <summary>
        /// This method takes two ints and returns the difference
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Diff(int num1, int num2)
        {
            //throw new NotImplementedException($"Diff() is not implemented yet");
             int z = num1 - num2;

            return z;
        }

        /// <summary>
        /// This method takes two ints and returns the product 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Product(int num1, int num2)
        {
            //throw new NotImplementedException($"Product() is not implemented yet");

            int b = num1 * num2;

            return b;
        }

        /// <summary>
        /// This method takes two ints and returns the quotient
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Quotient(int num1, int num2)
        {
            //throw new NotImplementedException($"Quotient() is not implemented yet");

             int q;
             int f = Math.DivRem(num1, num2, out q);

            return f;
        }

        /// <summary>
        /// This method returns the remainder.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static int Remainder(int num1, int num2)
        {
            //throw new NotImplementedException($"Remainder() is not implemented yet");

            int r = num1%num2;

            return r;
        }

        /// <summary>
        /// This method takes two ints and returns true if the first value is greater
        /// or equal to the second value, otherwise false.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="!"></param>
        /// <returns></returns>
        public static bool And(int num1, int num2)
        {
            //throw new NotImplementedException($"And() is not implemented yet");
            if(num1 >= num2){
                  
                  return true;
            }
            else{

                return false;
            }
            
        }

        /// <summary>
        /// This method takes two ints and returns true if num1 is
        /// greater than num2 or if num1 is greater than zero. Otherwise, false.
        /// </summary>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static bool Or(int num1, int num2)
        {
            //throw new NotImplementedException($"Or() is not implemented yet");
            if((num1 > num2) || (num1 > 0)){

                return false;
            }
            else{

                return true;
            }
        }
    }
}

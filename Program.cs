﻿using System;

namespace HelloWorld
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int number1 = 1;
            bool value = true;
            if (number1 > 10 || value == true)
            {
                Console.WriteLine("num is bigger");
            } 
            else if(number1 ==5)
            {
                number1 += 10;
            }
            else
            {
                Console.WriteLine("num is not bigger");
            }
            switch(number1)
            {
                case 5:
                    Console.WriteLine("num is a value");
                    break;
                case 10:
                    Console.WriteLine("num is not bigger");
                    break;
                default:
                break;        
            }
        }
         
    }
        
    
}
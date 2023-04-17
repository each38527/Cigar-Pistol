using System;

namespace HelloWorld
{
    internal class Program
    {
          public static void Main(string[] args)
        {
            int a = 5;
            int b = 7;   

            double result = Divide(a,b);
            int result1 = Multiply(a,b);
            int result2 = Plus(a,b);
            int result3 = Minus(a,b);

            Console.WriteLine(result);
            

            static double Divide(double num1, double num2)
            {
                return num1/num2;
            }

            static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Plus(int num1, int num2)
            {
                return num1 + num2;
            }

            static int Minus(int num1, int num2)
            {
                return num1 - num2;
            }


        }
    
         
    }
        
    
}
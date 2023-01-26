using System;

namespace CALCULATOR
{
  class Program
  {

    public static void Addition( int num1,int num2)
{
    int result = num1 + num2;
    Console.WriteLine("ANSWER IS: {0}", result);
}

    public static void Subtraction( int num1,int num2)
{
    int result = num1 - num2;
    Console.WriteLine("ANSWER IS: {0}", result);
}

    public static void Multiplication( int num1,int num2)
{
    int result = num1 * num2;
    Console.WriteLine("ANSWER IS: {0}", result);
}

    public static void Division( int num1,int num2)
{
    int result = num1 / num2;
    Console.WriteLine("ANSWER IS: {0}", result);
}

    public static void Modulas( int num1,int num2)
{
    int result = num1 % num2;
    Console.WriteLine("ANSWER IS: {0}", result);
}

    static void Main(string[] args)
    {
      Console.WriteLine("Enter Your 1st Number :");
      int num1 = int.Parse(Console.ReadLine())  ;  
      Console.WriteLine("Enter Your 2nd Number :");
      int num2 = int.Parse(Console.ReadLine())  ; 
      Console.WriteLine("Enter Operators (+, -, *, /, %)");
      string operation = (Console.ReadLine())  ;  

    if(operation.Equals("+")) 
    {
      Program.Addition(num1,num2);
    }

    else  if(operation.Equals("-")) 
    {
      Program.Subtraction(num1,num2);
    }

    else  if(operation.Equals("*")) 
    {
      Program.Multiplication(num1,num2);
    }

    else  if(operation.Equals("/")) 
    {
      Program.Division(num1,num2);
    }

        else  if(operation.Equals("%")) 
    {
      Program.Modulas(num1,num2);
    }

    else
    {
        System.Console.WriteLine("Invalid Error");
    }
 
    }
  }
}
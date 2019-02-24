using System;

namespace String_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now can write your name ");
           float number1 =float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());
            float minamal = number1 - number2;
            Console.WriteLine("number is  :"+minamal);
            Console.ReadKey();
            
        }
    }
}

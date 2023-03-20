using System;

namespace FizzBuzz
{
    class Program
    {
 public static string FizzOrBuzz(int x)
    {
        if (x % 5 == 0 && x % 3 == 0)
        {
            return "fizzbuzz";
        }
        else if (x % 5 == 0)
        {
            return "buzz";
        }
        else if (x % 3 == 0)
        {
            return "fizz";
        }
        else 
        return "";      
        
    }
static void Main(string[] args)
{
   Console.WriteLine(FizzOrBuzz(33));
   Console.WriteLine(FizzOrBuzz(45));
   Console.WriteLine(FizzOrBuzz(25));
   Console.WriteLine(FizzOrBuzz(2));
}
}
}
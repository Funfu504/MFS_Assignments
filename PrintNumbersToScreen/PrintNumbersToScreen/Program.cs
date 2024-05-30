using System;

namespace PrintNumbersToScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<String> theCount = NumberCounter.NumberCounter.PrintNumbers(30, "Forest", "Gump");
            
            foreach (var item in theCount)
            {
                Console.WriteLine(item);
            }
        }
    }
}

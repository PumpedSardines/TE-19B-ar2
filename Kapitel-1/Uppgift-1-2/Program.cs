using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[]{
                "Detta är ett pogram gjort i C#",
                "Programmet skriver ut text på flera rader.",
                "Detta är programmets sista utskrift."
            };
            Console.WriteLine(string.Join("\n",lines));
        }
    }
}
using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[]{
                "\"Hej\" hörde jag någon säga på stan.",
                "Efter en stund svarade någon annan också med ett \"Hej!\"."
            };
            Console.WriteLine(string.Join("\n",lines));
        }
    }
}
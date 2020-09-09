using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Förnamn: ")
            string firstName = Console.Readline();
            Console.WriteLine("Efternamn: ")
            string lastName = Console.Readline();

            Console.WriteLine("Hej! " + firstName + " " + lastName);
        }
    }
}
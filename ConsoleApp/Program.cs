using ConsoleApp.Data;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CineAluraContext())
            {
            }

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

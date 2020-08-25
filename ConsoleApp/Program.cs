using ConsoleApp.Data;
using ConsoleApp.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CineAluraContext())
            {
                Console.WriteLine("Clientes:");
                foreach (var cliente in context.Clientes)
                {
                    Console.WriteLine(cliente);
                }

                Console.WriteLine("\r\nFuncionarios:");
                foreach(var funcionario in context.Funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }


            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CineAluraContext())
            {
                var queryFilmes = context.Filmes;

                foreach (var filme in queryFilmes)
                {
                    Console.WriteLine(filme);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

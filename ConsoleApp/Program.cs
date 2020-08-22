using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                var query = context.Filmes
                    .Include(f => f.Elenco)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine(query);
                Console.WriteLine("Elenco:");
                foreach (var q in query.Elenco)
                {
                    Console.WriteLine(q.Ator);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

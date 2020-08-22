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
                var query = context.Categorias
                    .Include(c => c.Filmes)
                    .ThenInclude(f => f.Categoria)
                    .First();

                Console.WriteLine("Categoria {0}", query);
                Console.WriteLine("filmes:");
                foreach (var q in query.Filmes)
                {
                    Console.WriteLine("\t-{0}", q.Filme);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

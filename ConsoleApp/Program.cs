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
                var categorias = context.Categorias
                    .Include(c => c.Filmes)
                    .ThenInclude(f => f.Categoria)
                    .ToList();

                foreach (var categoria in categorias)
                {
                    Console.WriteLine("Categoria {0}", categoria);
                    foreach (var cf in categoria.Filmes)
                    {
                        Console.WriteLine(cf.Filme);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tecle 'enter' para finalizar a execução...");
            Console.ReadKey();
        }
    }
}

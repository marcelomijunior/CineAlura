using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp.Models
{
    public class Relatorio
    {
        public static void MostStarredActors(CineAluraContext context)
        {
            var sql = @"SELECT a.* 
                            FROM actor AS a INNER JOIN top5_most_starred_actors [top five]
                            ON [top five].actor_id = a.actor_id";

            var queryAtores = context.Atores
                .FromSqlRaw(sql)
                .Include(a => a.Filmografia);

            foreach (var ator in queryAtores)
            {
                Console.WriteLine($"O ator/Atriz {ator.PrimeiroNome} {ator.SegundoNome} atuou em {ator.Filmografia.Count} filmes.");
            }
        }
    }
}

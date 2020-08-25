using ConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Data.SqlClient;

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

        public static void TotalAtoresEstrelandoCategoria(CineAluraContext context, string categoria)
        {
            var paramCategoria = new SqlParameter("category_name", categoria);
            var paramToal = new SqlParameter()
            {
                ParameterName = "@total_actors",
                Size = 4,
                Direction = ParameterDirection.Output
            };

            context
                .Database
                .ExecuteSqlRaw("[total_actors_from_given_category] @category_name, @total_actors OUT", paramCategoria, paramToal);

            Console.WriteLine($"Total de atores que estrelaram filmes na categira {categoria} é de {paramToal.Value}.");
        }
    }
}

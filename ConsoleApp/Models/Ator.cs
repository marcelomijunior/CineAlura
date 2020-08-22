
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Ator
    {
        public Ator()
        {
            Filmografia = new List<FilmeAtor>();
        }

        public int? Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public IList<FilmeAtor> Filmografia { get; set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {SegundoNome}\n";
        }
    }
}

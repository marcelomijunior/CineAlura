using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Idioma
    {

        public Idioma()
        {
            FilmesFalados = new List<Filme>();
            FilmesOriginais = new List<Filme>();
        }
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<Filme> FilmesFalados { get; set; }
        public IList<Filme> FilmesOriginais { get; set; }

        public override string ToString()
        {
            return $"Idioma: {Nome}";
        }
    }
}

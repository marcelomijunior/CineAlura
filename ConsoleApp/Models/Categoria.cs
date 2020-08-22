using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Filmes = new List<FilmeCategoria>();
        }

        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<FilmeCategoria> Filmes { get; set; }

        public override string ToString()
        {
            return $"{Nome}\n";
        }
    }
}

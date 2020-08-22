﻿using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Filme
    {
        public Filme()
        {
            Elenco = new List<FilmeAtor>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public IList<FilmeAtor> Elenco { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {AnoLancamento}\n";
        }
    }
}
﻿using ConsoleApp.Extensions;
using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class Filme
    {
        public Filme()
        {
            Elenco = new List<FilmeAtor>();
            Categorias = new List<FilmeCategoria>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificacao { get; private set; }
        public ClassificacaoIndicativaEnum Classificacao
        {
            get { return TextoClassificacao.ParaValor(); }
            set { TextoClassificacao = value.ParaString(); }
        }
        public IList<FilmeAtor> Elenco { get; set; }
        public IList<FilmeCategoria> Categorias { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {AnoLancamento}\n";
        }
    }
}

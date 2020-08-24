using ConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Extensions
{
    public static class ClassificacaoIndicativaExtensions
    {
        private static IDictionary<string, ClassificacaoIndicativaEnum> map = new Dictionary<string, ClassificacaoIndicativaEnum>()
        {
            { "G",ClassificacaoIndicativaEnum.Livre },
            { "PG", ClassificacaoIndicativaEnum.MaioresDe10 },
            { "PG-13",  ClassificacaoIndicativaEnum.MaioresDe13 },
            { "R",  ClassificacaoIndicativaEnum.MaioresDe14 },
            { "R-17",  ClassificacaoIndicativaEnum.MaioresDe18 },
        };

        public static string ParaString(this ClassificacaoIndicativaEnum value)
        {
            return map.First(m => m.Value == value).Key;
        }

        public static ClassificacaoIndicativaEnum ParaValor(this string text)
        {
            return map.First(m => m.Key == text).Value;
        }
    }
}

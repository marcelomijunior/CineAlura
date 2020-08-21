
namespace ConsoleApp.Models
{
    public class Ator
    {
        public int? Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }

        public override string ToString()
        {
            return $"Ator: {PrimeiroNome} {SegundoNome}\n";
        }
    }
}

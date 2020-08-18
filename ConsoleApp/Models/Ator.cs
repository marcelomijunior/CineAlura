using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Ator
    {
        public int Id { get; set; }
        [Column("first_name", TypeName = "varchar(45)")]
        [Required]
        public string PrimeiroNome { get; set; }
        [Column("last_name", TypeName = "varchar(45)")]
        [Required]
        public string SegundoNome { get; set; }
        [Column("last_update", TypeName = "datetime")]
        public DateTime UltimaAtualizacao { get; set; }
    }
}

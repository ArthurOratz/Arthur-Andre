using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Agenda
{
    public class Contato
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public String Nome { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public String Sobrenome { get; set; }

        public DateTime Data { get; set; }

        [MaxLength(20)]
        public String Telefone { get; set; }

        public IList<Compromisso> Compromissos { get; set; }

    }
}

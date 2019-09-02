using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Agenda
{
    public class Compromisso
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public String Titulo { get; set; }

        [MaxLength(500)]
        public String Local { get; set; }

        [Required]
        public DateTime dataInicio { get; set; }

        public DateTime dataFim { get; set; }

        public IList<Contato> contatos { get; set; }
    }
}

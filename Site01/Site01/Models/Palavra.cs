using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Site01.Library.Validation;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="O campo Nome é obrigatorio")]
        [MaxLength(70, ErrorMessage ="O campo Nome deve conter no máximo 70 caracteres")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        //1-facil 2-medio 3-dificil
        public byte Nivel { get; set; }
    }
}

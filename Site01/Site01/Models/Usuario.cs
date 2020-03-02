using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="O campo Email é obrigatorio")]
        [EmailAddress(ErrorMessage ="O campo Email é invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="campo Senha é obrigatorio")]
        public string Senha { get; set; }
    }
}

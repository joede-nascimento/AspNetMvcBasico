using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Site01.Models;
using Site01.Database;

namespace Site01.Library.Validation
{
    public class UnicoNomePalavra : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra;

            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));
            var palavraBanco =_db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if(palavraBanco == null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("A palavra "+palavra.Nome+" ja esta sendo utilizada!");
            }
        }
    }
}

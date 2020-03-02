using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
            if(context.HttpContext.Session.GetString("Login") == null)
            {
                if(context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "Faça o login para poder acessar";
                }
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }

          
        }
    }
}

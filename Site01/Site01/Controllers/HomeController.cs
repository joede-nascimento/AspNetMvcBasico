using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site01.Models;
using Microsoft.AspNetCore.Http;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

            // return new ContentResult() { Content = "olá mundo2", ContentType = "text/json" };
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "joedeferreira2@gmail.com" && usuario.Senha == "123456")
                {
                    //add session
                    //HttpContext.Session.SetString("Login", "true");
                    //HttpContext.Session.SetInt32("UserID", 32);


                    //ler session
                    //string login = HttpContext.Session.GetString("Login")

                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são invalidos";
                    return View();
                }
            }
            else
            {
                return View();
            }
            
            
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}

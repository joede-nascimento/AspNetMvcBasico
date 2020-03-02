using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using Site01.Database;
using Site01.Library.Filters;
using X.PagedList;

namespace Site01.Controllers
{
    [Login]
    public class PalavraController : Controller
    {
        List<Nivel> niveis = new List<Nivel>();
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;

            
            niveis.Add(new Nivel() { Id = 1, Nome = "Facil" });
            niveis.Add(new Nivel() { Id = 2, Nome = "Medio" });
            niveis.Add(new Nivel() { Id = 3, Nome = "Dificil" });
        }

        //lista todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var palavras = _db.Palavras.ToList();
            var resultadoPaginado = palavras.ToPagedList(pageNumber, 5);
            return View(resultadoPaginado);
        }

        //crud
        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Nivel = niveis;
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            ViewBag.Nivel = niveis;
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = "A palavra"+palavra.Nome+"foi cadastrada com sucesso!";

                return RedirectToAction("index");
            }
            
            return View(palavra);
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            ViewBag.Nivel = niveis;
            Palavra palavra = _db.Palavras.Find(Id);
            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();
                TempData["Mensagem"] = "A palavra" + palavra.Nome + "foi atualizada com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", palavra);
        }

        //Palavra/Excluir/39
        //{Controller}/{Action}/{Id?}
        [HttpGet]
        public IActionResult Excluir(int Id)
        { 

            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi excluida com sucesso!";
            return  RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Areas.Painel.Models;

namespace WebApplication4.Areas.Painel.Controllers
{
    public class InicioController : Controller
    {
        public string NameUser { get; set; }
        //
        // GET: /Painel/Inicio/
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("DadosCadastrais");
            }
            return View();
        }
        public ActionResult DadosCadastrais(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
    
}
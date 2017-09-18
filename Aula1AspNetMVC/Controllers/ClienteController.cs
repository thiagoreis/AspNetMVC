using Aula1AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1AspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Teste()
        {
            var cliente = new Cliente()
            {
                Nome = "ASP",
                SobreNome = "MVC5",
                DataCadastro = DateTime.Now,
                Id = 1,
            };
            ViewBag.Cliente = "Texto";
            //ViewData["Cliente"] = cliente;
            return View( "Index", cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){Nome = "Cliente 1", SobreNome = "Teste", DataCadastro = DateTime.Now},
                new Cliente(){Nome = "Cliente 2", DataCadastro = DateTime.Now},
                new Cliente(){Nome = "Cliente 3", DataCadastro = DateTime.Now}
            };
            return View(listaClientes);
        }

        public ActionResult Pesquisa(int? id, string nome)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente(){Nome = "Cliente 1", SobreNome = "Teste", DataCadastro = DateTime.Now, Id = 1},
                new Cliente(){Nome = "Cliente 2", DataCadastro = DateTime.Now, Id = 2},
                new Cliente(){Nome = "Cliente 3", DataCadastro = DateTime.Now, Id = 3}
            };
            var cliente = listaClientes.Where(c => c.Nome == nome).ToList();
            if(!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente encontrado";
                return RedirectToAction("ErroPesquisa");
            }
            return View("Lista",cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}
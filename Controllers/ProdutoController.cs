using Microsoft.AspNetCore.Mvc;
using Projeto_Conexao_MYSQL.Data; // Importa o seu AppDbContext
using Projeto_Conexao_MYSQL.Models;
using System.Collections.Generic;
using System.Linq; // Permite usar o método .ToList()

namespace Projeto_Conexao_MYSQL.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;

        // O ASP.NET Core passa o banco de dados automaticamente para cá (Injeção de Dependência)
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Busca todos os produtos cadastrados fisicamente no seu banco de dados
            List<Produto> ListaProdutos = _context.Produtos.ToList();

            ViewBag.Produtos = ListaProdutos;

            return View();
        }
    }
}

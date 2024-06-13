using Microsoft.AspNetCore.Mvc;
using PsiConnect.Models;
using PsiConnect.Repositorios.Interfaces;

namespace PsiConnect.Controllers
{
    public class PsiConnectController : Controller
    {
        private readonly IPsiConnectRepositorio _psiConnectRepositorio;
        public PsiConnectController(IPsiConnectRepositorio psiConnectRepositorio)
        {
            _psiConnectRepositorio = psiConnectRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tela_de_Cadastro()
        {
            return View();
        }

        public IActionResult Tela_de_Editar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tela_de_Cadastro(Usuario usuario) 
        {
            _psiConnectRepositorio.Cadastrar(usuario);
            return RedirectToAction("Index");
        }
        public IActionResult Tela_de_CadastroPsi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tela_de_CadastroPsi(Psicologos psicologos)
        {
            _psiConnectRepositorio.CadastrarPsi(psicologos);
            return RedirectToAction("Index");
        }
    }
}

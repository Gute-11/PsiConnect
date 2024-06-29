using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsiConnect.Models;
using PsiConnect.Repositorios.Interfaces;
using PsiConnect.ViewModels;

namespace PsiConnect.Controllers
{
    public class PsiConnectController : Controller
    {
        private readonly IPsiConnectRepositorio _psiConnectRepositorio;
        public PsiConnectController(IPsiConnectRepositorio psiConnectRepositorio)
        {
            _psiConnectRepositorio = psiConnectRepositorio;
        }

        public IActionResult Tela_de_Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tela_de_Cadastro(Usuario usuario)
        {
            _psiConnectRepositorio.Cadastrar(usuario);
            return RedirectToAction("Tela_Inicial_Usuario");
        }
        public IActionResult Tela_de_CadastroPsi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Tela_de_CadastroPsi(Psicologos psicologos)
        {
            _psiConnectRepositorio.CadastrarPsi(psicologos);
            return RedirectToAction("Tela_Inicial_Psic");
        }

        public IActionResult Tela_de_Chat()
        {
            return View();
        }

        [Authorize(Policy = "PsicologoPolicy")]
        public IActionResult CadastrarProntuario()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "PsicologoPolicy")]
        public IActionResult CadastrarProntuario(Prontuario prontuario)
        {
            if (ModelState.IsValid)
            {
                _psiConnectRepositorio.CadastrarProntuario(prontuario);
                TempData["MensagemSucesso"] = "Prontuário cadastrado com sucesso!";
                return RedirectToAction("CadastrarProntuario");
            }
            return View(prontuario);
        }

        [Authorize(Policy = "PsicologoPolicy")]
        public IActionResult Tela_Inicial_Psic()
        {
            return View();
        }

        public IActionResult Tela_Inicial_Usuario()
        {
            return View();
        }

        [Authorize(Policy = "PsicologoPolicy")]
        public IActionResult Tela_Perfil_Psic()
        {
            //List<CadastroPsicologoViewModel> _psiConnectRepositorio.BuscarNomePsic();
            return View();
        }

        public IActionResult Tela_Perfil_Usua()
        {
            return View();
        }

    }
}

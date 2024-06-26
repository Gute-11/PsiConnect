﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PsiConnect.Context;
using PsiConnect.Models;
using PsiConnect.ViewModels;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly AppDbContext _context;
    private readonly ILogger<AccountController> _logger;

    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, AppDbContext context, ILogger<AccountController> logger)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
        _logger = logger;
    }

    public IActionResult Login(string returnUrl)
    {
        return View(new LoginViewModel() { ReturnUrl = returnUrl });
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel loginViewModel)
    {
        if (!ModelState.IsValid)
            return View(loginViewModel);

        var user = await _userManager.FindByEmailAsync(loginViewModel.Email_u);

        if (user != null)
        {
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Senha_u, false, false);
            if (result.Succeeded)
            {
                var isPsicologo = await _userManager.IsInRoleAsync(user, "Psicologo");

                if (isPsicologo)
                {
                    return RedirectToAction("Tela_Inicial_Psic", "PsiConnect");
                }
                else
                {
                    return RedirectToAction("Tela_Inicial_Usuario", "PsiConnect");
                }
            }
        }

        ModelState.AddModelError("", "Falha ao realizar o Login!, tente novamente");
        return View(loginViewModel);
    }


    public IActionResult Cadastro_Usuario()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Cadastro_Usuario(CadastroUsuarioViewModel cadastroViewModel)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogInformation("ModelState is invalid");
            foreach (var error in ModelState)
            {
                _logger.LogError($"Key: {error.Key}, Error: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
            }
            return View(cadastroViewModel);
        }

        var user = new IdentityUser { UserName = cadastroViewModel.Primeiro_nome_u, Email = cadastroViewModel.Email_u };
        var result = await _userManager.CreateAsync(user, cadastroViewModel.Senha_u);

        if (result.Succeeded)
        {
            var usuario = new Usuario
            {
                Primeiro_nome_u = cadastroViewModel.Primeiro_nome_u,
                Sobrenome_u = cadastroViewModel.Sobrenome_u,
                Cpf_u = cadastroViewModel.Cpf_u,
                Email_u = cadastroViewModel.Email_u,
                Celular_u = cadastroViewModel.Celular_u,
                Ctt_emer_u = cadastroViewModel.Ctt_emer_u,
                Senha_u = cadastroViewModel.Senha_u,
                Genero_u = cadastroViewModel.Genero_u
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login", "Account");
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View(cadastroViewModel);
    }

    public IActionResult CadastroPsicologo()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CadastroPsicologo(CadastroPsicologoViewModel cadastroPsicologoViewModel)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogInformation("ModelState is invalid");
            foreach (var error in ModelState)
            {
                _logger.LogError($"Key: {error.Key}, Error: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
            }
            return View(cadastroPsicologoViewModel);
        }

        var user = new IdentityUser { UserName = cadastroPsicologoViewModel.Primeiro_nome_p, Email = cadastroPsicologoViewModel.Email_p };
        var result = await _userManager.CreateAsync(user, cadastroPsicologoViewModel.Senha_p);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "Psicologo");

            var psicologo = new Psicologos
            {
                Primeiro_nome_p = cadastroPsicologoViewModel.Primeiro_nome_p,
                Sobrenome_p = cadastroPsicologoViewModel.Sobrenome_p,
                Email_p = cadastroPsicologoViewModel.Email_p,
                Cpf_p = cadastroPsicologoViewModel.Cpf_p,
                Celular_p = cadastroPsicologoViewModel.Celular_p,
                CRM = cadastroPsicologoViewModel.CRM,
                Estado = cadastroPsicologoViewModel.Estado,
                Senha_p = cadastroPsicologoViewModel.Senha_p,
                Genero_p = cadastroPsicologoViewModel.Genero_p
            };

            _context.Psicologos.Add(psicologo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login", "Account");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View(cadastroPsicologoViewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        HttpContext.Session.Clear();
        HttpContext.User = null;
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
}

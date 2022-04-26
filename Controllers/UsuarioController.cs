using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario u)
        {
            u.Senha = Criptografo.TextoCriptografado(u.Senha);
            new UsuarioService().Inserir(u);
            return RedirectToAction("CadastroSucesso");
        }

        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);
            return View(new UsuarioService().Listar());
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult Edicao(Usuario u)
        {
            u.Senha = Criptografo.TextoCriptografado(u.Senha);
            new UsuarioService().Editar(u);
            return RedirectToAction("Listagem");
        }

        public IActionResult Sair() 
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult CadastroSucesso()
        {
            return View();
        }

        public IActionResult Exclusao(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioEAdmin(this);
            return View(new UsuarioService().Listar(id));
        }

        [HttpPost]
        public IActionResult Exclusao(string decisao, int id)
        {
            if (decisao == "EXCLUIR")
            {
                new UsuarioService().Excluir(id);
            } 
            return View("Listagem", new UsuarioService().Listar());           
        }
    }
}
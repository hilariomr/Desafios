using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC_.Enums;
using RoleTopMVC_.Repositories;
using RoleTopMVC_.ViewsModels;

namespace RoleTopMVC_.Controllers {
    public class LoginController : AbstractController {
        ClienteRepository clienteRepository = new ClienteRepository ();

        [HttpGet]
        public IActionResult Index () {
            return View (new BaseViewModel () {
                NomeView = "Login"
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("=================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("=================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor (usuario);

                if (cliente != null) {
                    if (cliente.Senha.Equals (senha)) {
                        switch (cliente.TipoUsuario) {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Index", "Galeria");

                            default:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Index", "Galeria");
                        }
                    } else {
                        return View ("Erro", new RespostaViewModel ("Senha incorreta"));
                    }
                } else {
                    return View ("Erro", new RespostaViewModel ($"Usuário {usuario} não encontrado"));
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel (e.Message));
            }
        }
    }
}
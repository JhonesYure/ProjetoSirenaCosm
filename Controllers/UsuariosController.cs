using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ATV4PI.Models;
namespace ATV4PI.Controllers
{
    public class UsuariosController : Controller
    {
//LISTA
      public IActionResult lista()
      {
        
          UsuariosRepository ur = new UsuariosRepository();
          List<Usuarios> listagem = ur.Lista();
          return View(listagem);
      }    

//EXCLUIR
      public IActionResult excluir(int Id)
      {
         UsuariosRepository ur = new UsuariosRepository();
         Usuarios user = ur.buscarId(Id);

         ur.deletar(user);

         return RedirectToAction ("Lista");
      }   
//INSERIR
      public IActionResult inserir()
      {
          return View();
      }           
      [HttpPost]
      
      public IActionResult inserir(Usuarios user)
      {
          UsuariosRepository ur = new UsuariosRepository();
          ur.inserir(user);
          ViewData["mensagem"] = "Cadastro realizado com sucesso";

          return View();
      }
//ALTERAR
      public IActionResult alterar(int Id)
      {
          UsuariosRepository ur = new UsuariosRepository();
          Usuarios userFind  = ur.buscarId(Id);

          return View(userFind);
      }      
      [HttpPost]
      public IActionResult alterar(Usuarios user)
      {
          if (HttpContext.Session.GetInt32("IdUsuario")==null)
        {
            return RedirectToAction("Email","Id");
        }
          UsuariosRepository ur = new UsuariosRepository();
          ur.atualizar(user);

          return RedirectToAction("Lista");
      }
//LOGIN
     public IActionResult Login(Usuarios user)
     {
         UsuariosRepository ur = new UsuariosRepository();
         Usuarios userSessao = ur.validar(user);

         if(userSessao==null)
         {
             ViewBag.mensagem = "Usuario não encontrado";
             return View();
         }
         else{
             ViewBag.mensagem = "Você está logado";

             HttpContext.Session.SetInt32("IdUsuario",userSessao.Id);
             HttpContext.Session.SetString("NomeUsuario",userSessao.Nome);

             return RedirectToAction("Lista");
         }
     }
//LOGOUT
         public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return View("Login");
        }     
     }      
    }

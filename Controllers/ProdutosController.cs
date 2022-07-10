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
    public class ProdutosController : Controller
    {
//AGENDA
     public IActionResult Pedidos()
     {
           
        if (HttpContext.Session.GetInt32("IdUsuario")==null)
        {
            return RedirectToAction("Login","Usuarios");
        }
        ProdutosRepository pr = new ProdutosRepository();
        List<Produtos> pedidos = pr.produtos();

        UsuariosRepository ur = new UsuariosRepository();
        List<Usuarios> lista = ur.Lista();

        return View(pedidos);
     }
//EXCLUIR
     public IActionResult excluir(int IdProduto)
     {
         ProdutosRepository pr = new ProdutosRepository();
         Produtos prod = pr.buscarId(IdProduto);

         pr.deletar(prod);

         return RedirectToAction("Pedidos");
     }
//INSERIR
     public IActionResult inserir(int IdProduto)
     {
           
        if (HttpContext.Session.GetInt32("IdUsuario")==null)
        {
            return RedirectToAction("Login","Usuarios");
        }
         return View();
     }     
     [HttpPost]
     public IActionResult inserir(Produtos novoProduto)
     {
           
        if (HttpContext.Session.GetInt32("IdUsuario")==null)
        {
            return RedirectToAction("Login","Usuarios");
        }
        ProdutosRepository pr = new ProdutosRepository();
        novoProduto.IdUsuario = (int)(HttpContext.Session.GetInt32("IdUsuario"));
        pr.inserir(novoProduto);

        return RedirectToAction("Pedidos");
     }
//ALTERAR
   public IActionResult alterar(int IdProduto)
   {
       ProdutosRepository pr = new ProdutosRepository();
       Produtos prodEncontrado = pr.buscarId(IdProduto);

       return View(prodEncontrado);
   }
   [HttpPost]
   public IActionResult alterar(Produtos prod)
   {
       ProdutosRepository pr = new ProdutosRepository();
       pr.atualizar(prod);

       return RedirectToAction ("Pedidos");
   }
    
    
    
    
    }




}
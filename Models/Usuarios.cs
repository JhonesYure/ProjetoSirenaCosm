using System;
using System.Collections.Generic;
namespace ATV4PI.Models
{
    public class Usuarios
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Sobrenome {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
        public string CPF {get;set;}
        public string Telefone {get;set;}
        public string Sexo {get;set;}
        public string Senha {get;set;}

    }
}
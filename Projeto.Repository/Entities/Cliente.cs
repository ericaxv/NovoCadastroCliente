﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repository.Entities
{
   public class Cliente
    {
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {IdCliente}, Nome: {Nome}, Email: {Email}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAcesso
{
    class Usuario
    {
        public Usuario() { }

        public int Codigo {  get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Usuario> ListaUsuario = new List<Usuario>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFuncionario.Models
{
    public class Usuario
    {
        public string NomeUsuario { get; set; }
        public string FuncaoUsuario { get; set; } // tecnico/administrador
        public string EscalaUsuario { get; set; } // dia / noite
    }
}

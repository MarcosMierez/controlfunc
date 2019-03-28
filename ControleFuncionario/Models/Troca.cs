using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFuncionario.Models
{
    public class Troca
    {
        public string IdTroca { get; set; }
        public int IdSoliciatante { get; set; }
        public int IdSolicitado { get; set; }
        public string StatusTroca { get; set; } // solicitada - aprovada - recusada
    }
}

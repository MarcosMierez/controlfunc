using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFuncionario.Models
{
    public class TrocaViewModel
    {
        public string IdTroca { get; set; }
        public string NomeSolicitante { get; set; }
        public string NomeSolicitado { get; set; }
        public string Dia { get; set; }
        public string Turno { get; set; }
        public string Status { get; set; }
    }
}

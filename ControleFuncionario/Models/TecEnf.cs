using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFuncionario.Models
{
    public class TecEnf
    {
        public string NomeTec { get; set; }
        public string DiaMes { get; set; }
        public string Turno { get; set; }
        private string Solicitante;
        public string solicitante
        {
            get {
                string solicitante = "Marcos Vinicius";
                return solicitante;
                    }
            set
            {
                Solicitante = solicitante;
            }

        }


    }
}

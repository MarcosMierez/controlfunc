using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFuncionario.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleFuncionario.Controllers
{
    public class PaginaInicialController : Controller
    {

        public List<String> funcinariosRandon = new List<string>(); // essa lista posteriormente vira do banco de dados
        public static TrocaViewModel trocaTemporaria = new TrocaViewModel(); // usando isso apenas pq ainda nao instalamos o Bd.

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trocas()
        {

            TrocaViewModel troca = new TrocaViewModel();
            troca = trocaTemporaria;
            return View(troca);
        }

        public IActionResult SolicitarTroca()
        {
            funcinariosRandon.Add("Adriana");
            funcinariosRandon.Add("Jessica");
            funcinariosRandon.Add("Daniela");
            funcinariosRandon.Add("Manuela");
            ViewBag.contador = funcinariosRandon.Count();
            ViewBag.listaFunc = new List<string>();
            ViewBag.listaFunc = funcinariosRandon;

            return View(new TecEnf());
        }

        [HttpPost]
        public IActionResult SolicitarTroca(string funcionario, string turno, string diadoMes)

        {
            funcinariosRandon.Add("Adriana");
            funcinariosRandon.Add("Jessica");
            funcinariosRandon.Add("Daniela");
            funcinariosRandon.Add("Manuela");
            ViewBag.contador = funcinariosRandon.Count();
            ViewBag.listaFunc = new List<string>();
            ViewBag.listaFunc = funcinariosRandon;


            TecEnf usuario = new TecEnf();
            usuario.NomeTec = funcionario;
            usuario.Turno = turno;
            usuario.DiaMes = diadoMes;

            trocaTemporaria.IdTroca = "1";
            trocaTemporaria.NomeSolicitado = funcionario;
            trocaTemporaria.NomeSolicitante = usuario.solicitante;
            trocaTemporaria.Turno = turno;
            trocaTemporaria.Dia = diadoMes;
            trocaTemporaria.Status = "Solicitada";

            if (!String.IsNullOrEmpty(trocaTemporaria.NomeSolicitado))
            {
                return RedirectToAction("Trocas");
            }
            return View(usuario);
        }
        public ActionResult ResultadoTroca()
        {
            return View();
        }

        public ActionResult SetarTroca(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                switch (id)
                {
                    case "aut":
                        trocaTemporaria.Status = "Aguardando Aprovação";
                        break;
                    default:
                        trocaTemporaria.Status = "Cancelada";
                        break;
                }


            }

            return RedirectToAction("Trocas");
        }
    }
}
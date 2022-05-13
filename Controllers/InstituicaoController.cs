using Cap01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cap01.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>(){
            new Instituicao(){InstituicaoID = 1,
                Nome = "Fatec",
                Endereco = "Taquaritinga"

            },
            new Instituicao(){InstituicaoID = 2,
                Nome = "Itis",
                Endereco = "Taquaritinga",
            },
            new Instituicao(){InstituicaoID = 3,
                Nome = "Santa Ursula",
                Endereco = "Araraquara",
            },
            new Instituicao(){InstituicaoID = 4,
                Nome =  "Santa Monica",
                Endereco = "São Carlos",
            }
        };
        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.Nome));
        }
        /*creat abaixo*/
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i =>  i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }

        /*edit abaixo*/
        public IActionResult Edit(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        /*Detalhes Abaixo*/
        public ActionResult Details(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        /* Delete abaixo*/
        public ActionResult Delete(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            return RedirectToAction("Index");
        }
    }
}

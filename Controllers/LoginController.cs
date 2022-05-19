using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap01.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Entrar(string login, string senha)
        {
            return Redirect("/");
        }
        public async Task<IActionResult> Logoff()
        {

        }
    }
}

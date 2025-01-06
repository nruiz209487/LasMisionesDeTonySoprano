using ENT;
using LasMisionesDeTonySoprano.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LasMisionesDeTonySoprano.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult MainPage()
        {
            MainPageVM paginaPrincipalOBJ;
            try { paginaPrincipalOBJ = new MainPageVM(); }
            catch (Exception ex)
            {

                return View("Error");
            }

            return View(paginaPrincipalOBJ);
        }

        // GET: HomeController/Details/5
        public ActionResult SecondPage(Candidato obj)
        {
            CandidatoConEdad obj2 = new CandidatoConEdad(obj);
            return View(obj2);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

    }
}

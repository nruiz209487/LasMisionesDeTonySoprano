using ENT;
using LasMisionesDeTonySoprano.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LasMisionesDeTonySoprano.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController1/MainPage
        public ActionResult MainPage()
        {
            MainPageVM objMainPage;
            try
            {
                objMainPage = new MainPageVM();
                return View(objMainPage);
            }
            catch (Exception)
            {
                return View("ErrorPage");
            }


        }

        // POST: HomeController1/MainPage
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MainPage(MainPageVM model)
        {
            try
            {
                return View(model);
            }
            catch (Exception)
            {
                return View("ErrorPage");
            }
        }



        public ActionResult SecondPage(int idCandidato)
        {
            Candidato objCandidato;
            try
            {
                objCandidato = BL.ReglasDeEmpresa.ObtenerCandidatoPorId(idCandidato);
                CandidatoConEdad objSecondPage = new CandidatoConEdad(objCandidato);
                return View(objSecondPage);
            }
            catch (Exception)
            {
                return View("ErrorPage");
            }

        }


    }
}

using MechanikKonsola;
using MechanikKonsola.Comands;
using MechanikKonsola.Entities;
using MechanikKonsola.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mechanik.Controllers
{
    public class MechanikController : Controller
    {
        public IActionResult DodajRezerwacje()
        {
            return View();
        }
        public IActionResult RezT()
        {
            return View();
        }
        public IActionResult RezF()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DodajRezerwacje(DodajRezerwacjeKomenda command)
        {
            if (new DodajRezerwacjeHandler(command).Handle() == false) { return RedirectToAction("RezF", "Mechanik"); }
            else { return RedirectToAction("RezT", "Mechanik"); }
        }
        public IActionResult Uslugi() {
        return View(new PobierzUslugiQuery().Pobieranie());
        }
        public IActionResult ZakCzesci(int ID) {
            new UsunCzescQuery(ID).UsunCzesc();
            


            using (var contex = new AppDBContext())
            {
                if (contex.Czesci.Find(ID).IloscNaMagazynie > 0)
                {
                    ViewData["Wypis"] = "Zakupiłeś Część";
                }
                else
                {
                    ViewData["Wypis"] = "Nie udało się zakupić - brak na magazynie.";
                }

            }



            return View();
        }
        public IActionResult Czesci()
        {
            return View(new PobierzCzesciQuery().Pobieranie());
        }
    }
}

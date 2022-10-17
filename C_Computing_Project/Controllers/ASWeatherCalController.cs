using C_Computing_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Computing_Project.Controllers
{
    public class ASWeatherCalController : Controller
    {
        // GET: ASWeatherCalController
        public ActionResult Index()
        {
            var CModel = new AppServerWeatherCalModel();
            var result = CModel.GetWeatherCalService("Tel Aviv");
            return View(result);
        }

        // GET: ASWeatherCalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ASWeatherCalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASWeatherCalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ASWeatherCalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ASWeatherCalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ASWeatherCalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ASWeatherCalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

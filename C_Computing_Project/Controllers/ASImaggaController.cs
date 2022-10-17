using C_Computing_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Computing_Project.Controllers
{
    public class ASImaggaController : Controller
    {
        // GET: ASImaggaController
        public ActionResult Index()
        {
            string temp = "https://www.foodisgood.co.il/wp-content/uploads/2022/04/yeast-free-quick-pizza.jpg";
            var CModel = new AppServerImaggaModel();
            var result = CModel.GetImaggaService(temp);
            return View(result);
        }

        // GET: ASImaggaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ASImaggaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASImaggaController/Create
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

        // GET: ASImaggaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ASImaggaController/Edit/5
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

        // GET: ASImaggaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ASImaggaController/Delete/5
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

using C_Computing_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Computing_Project.Controllers
{
    public class ASHebCalController : Controller
    {
        // GET: ASHebCalController
        public ActionResult Index()
        {
            //galit
            var CModel=new AppServerHebCalModel();
            var result = CModel.GetHebCalService("IL-Tel Aviv");
            return View(result);
        }

        // GET: ASHebCalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ASHebCalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASHebCalController/Create
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

        // GET: ASHebCalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ASHebCalController/Edit/5
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

        // GET: ASHebCalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ASHebCalController/Delete/5
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

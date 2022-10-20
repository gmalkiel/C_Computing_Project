using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C_Computing_Project.Data;
using C_Computing_Project.Models;

namespace C_Computing_Project.Controllers
{
    public class RecipesController : Controller
    {
        private readonly C_Computing_ProjectContext _context;

        public RecipesController(C_Computing_ProjectContext context)
        {
            _context = context;
        }

        // GET: Recipes

        public async Task<IActionResult> Index()
        {
          
            var CModel = new AppServerWeatherCalModel();
            var result = CModel.GetWeatherCalService("Tel Aviv");
            ViewData["Weather"] = result;

            var CModel2 = new AppServerHebCalModel();
            var result2 = CModel2.GetHebCalService("IL-Tel Aviv");
            if (result2 != null)
            {
                ViewData["holidy"] = result2;
            }
           
            return View();
        }

        public async Task<IActionResult> IndexBread()
        {
            return View(await _context.Recipe.ToListAsync());
        }
        public async Task<IActionResult> IndexFish()
        {
            return View(await _context.Recipe.ToListAsync());
        }
        public async Task<IActionResult> IndexDessert()
        {
            return View(await _context.Recipe.ToListAsync());
        }
        public async Task<IActionResult> IndexSalad()
        {
            return View(await _context.Recipe.ToListAsync());
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Recipe == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImageUrl,Ingredients,Tags")] Recipe recipe)
        {
            
            var CModel = new AppServerImaggaModel();
            string result = CModel.GetImaggaService(recipe.ImageUrl);
            if (result=="false")
            {
                ViewData["imaggaalert"] = "this is not food";
            }
            //else ViewData["imaggaalert"] = string.Empty;
            if (ModelState.IsValid && result == "true")
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recipe == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImageUrl,Ingredients,Tags")] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Recipe == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Recipe == null)
            {
                return Problem("Entity set 'C_Computing_ProjectContext.Recipe'  is null.");
            }
            var recipe = await _context.Recipe.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipe.Remove(recipe);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
          return _context.Recipe.Any(e => e.Id == id);
        }
    }
}

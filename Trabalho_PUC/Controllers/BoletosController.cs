using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_PUC.Models;

namespace Trabalho_PUC.Controllers
{
    public class BoletosController : Controller
    {
        private readonly AppDbContext _context;
        public BoletosController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Boletos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(Boletos boletos) 
        {
            if (ModelState.IsValid)
            {
                _context.Boletos.Add(boletos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(boletos);
        }
         
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return NotFound();

            var dados = await _context.Boletos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, Boletos boletos)
        {
            if (id != boletos.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Boletos.Update(boletos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();

        }
           
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
                return NotFound();  

            var dados = await _context.Boletos.FindAsync(id);

            if(dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Boletos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Boletos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Boletos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }

}

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_PUC.Models;


namespace Trabalho_PUC.Controllers
{
    public class GruposController : Controller
    {
        private readonly AppDbContext _context;
        public GruposController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Grupos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                _context.Grupos.Add(grupo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View(grupo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Grupos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Grupo grupo)
        {
            if (id !=grupo.Id)
                return NotFound();

            if (ModelState.IsValid)
            {

                _context.Grupos.Update(grupo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Grupos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Grupos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Grupos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}

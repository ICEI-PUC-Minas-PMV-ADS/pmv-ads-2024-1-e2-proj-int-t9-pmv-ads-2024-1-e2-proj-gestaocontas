using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Trabalho_PUC.Models;

namespace Trabalho_PUC.Controllers
{
    public class PhysicalController : Controller
    {
        private readonly AppDbContext _context;
        public PhysicalController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.PhysicalMoneys.ToListAsync();

            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PhysicalMoney gastofisico)
        {
            if (ModelState.IsValid)
            {
                _context.PhysicalMoneys.Add(gastofisico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(gastofisico);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.PhysicalMoneys.FindAsync(id);
            if (id == null)
                return NotFound();
            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PhysicalMoney gastofisico)
        {
            if (id != gastofisico.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                _context.PhysicalMoneys.Update(gastofisico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            var dados = await _context.PhysicalMoneys.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.PhysicalMoneys.FindAsync(id);
            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleteconfirmed(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.PhysicalMoneys.FindAsync(id);
            if (dados == null)
                return NotFound();
            _context.PhysicalMoneys.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}

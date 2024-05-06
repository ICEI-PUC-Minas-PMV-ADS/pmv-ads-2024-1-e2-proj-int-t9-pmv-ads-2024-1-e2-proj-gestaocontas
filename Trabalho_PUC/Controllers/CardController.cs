using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Trabalho_PUC.Models;

namespace Trabalho_PUC.Controllers
{
    public class CardController : Controller
    {
        private readonly AppDbContext _context;

        public CardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cartoes = await _context.Cards.ToListAsync();

            return View(cartoes);
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            if (ModelState.IsValid)
            {
                _context.Add(card);
                await  _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            
            return View(card);
        }

        public async Task<IActionResult>  Edit(int? id)
        {
            if(id == null)
                return NotFound();

            var card = await _context.Cards.FindAsync(id);

            if (card == null) 
                return NotFound();

            return View(card);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Card card)
        {

            if(id != card.Id) 
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(card);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(card);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var card = await _context.Cards.FindAsync(id);

            if (card == null)
                return NotFound();

            return View(card);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var card = await _context.Cards.FindAsync(id);

            if (card == null)
                return NotFound();

            return View(card);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var card = await _context.Cards.FindAsync(id);

            if (card == null)
                return NotFound();

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}

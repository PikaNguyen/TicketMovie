using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Data;
using TicketMovie.Models;

namespace TicketMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.Include(x=>x.Cinema).ToListAsync();
            return View(data);
        }


        [HttpPost]
        public IActionResult Edit(int id, Movie actor)
        {
            //var data = _context.Actors.ToList();
            if (!ModelState.IsValid)
            {
                return View(actor);

            }
            _context.Movies.Update(actor);
            return RedirectToAction(nameof(Index));
        }
        //get: actor/delete
        //public IActionResult Delete(int id)
        //{
        //    var actorEdit = _service.GetById(id);
        //    if (actorEdit == null) return View("Empty");
        //    return View(actorEdit);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    var actorDelete = _service.GetById(id);
        //    if (actorDelete == null) return View("NotFound");
        //    _service.Delete(id);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}

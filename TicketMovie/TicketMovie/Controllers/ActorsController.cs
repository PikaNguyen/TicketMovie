using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Data;
using TicketMovie.Data.Services;
using TicketMovie.Models;

namespace TicketMovie.Controllers
{
    public class ActorsController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            //var data = _context.Actors.ToList();
            if (!ModelState.IsValid)
            {
            return View();

            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
        //get:Actor/edit
        public IActionResult Edit(int id)
        {
            var actorEdit = _service.GetById(id);
            if (actorEdit == null) return View("Empty");
            return View(actorEdit);
        }

        [HttpPost]
        public IActionResult Edit(int id,Actor actor)
        {
            //var data = _context.Actors.ToList();
            if (!ModelState.IsValid)
            {
                return View(actor);

            }
            _service.Update(id,actor);
            return RedirectToAction(nameof(Index));
        }
        //get: actor/delete
        public IActionResult Delete(int id)
        {
            var actorEdit = _service.GetById(id);
            if (actorEdit == null) return View("Empty");
            return View(actorEdit);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var actorDelete = _service.GetById(id);
            if (actorDelete == null) return View("NotFound");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}

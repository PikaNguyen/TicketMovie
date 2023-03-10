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
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Data;

namespace TicketMovie.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ActorsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}

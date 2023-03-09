using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Data;

namespace TicketMovie.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dataProducers = await _context.Actors.ToListAsync();
            return View();
        }
    }
}

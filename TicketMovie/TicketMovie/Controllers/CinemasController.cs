using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Data;

namespace TicketMovie.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CinemasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dataCinemas = await _context.Actors.ToListAsync();
            return View();
        }
    }
}

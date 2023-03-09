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
        public IActionResult Index()
        {
            var dataProducers =  _context.Producers.ToList();
            return View(dataProducers);
        }
    }
}

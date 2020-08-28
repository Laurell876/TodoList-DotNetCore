using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class TodosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodosController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Get Todos
        public async Task<IActionResult> Index()
        {
            return View(await _db.Todos.ToListAsync());
        }


    }
}

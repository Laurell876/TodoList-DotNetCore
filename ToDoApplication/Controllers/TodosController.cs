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

        [BindProperty]
        public Todo Todo { get; set; }

        public TodosController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Get Todos
        public async Task<IActionResult> Index()
        {
            return View(await _db.Todos.ToListAsync());
        }

        // Delete Todo
        [HttpPost]
        public async Task<IActionResult> Delete(int todoId)
        {


            var todoFromDb = await _db.Todos.FirstOrDefaultAsync(u => u.Id == todoId);
            if(todoFromDb == null) { return NotFound(); }
            
                _db.Todos.Remove(todoFromDb);
                await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}

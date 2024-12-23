﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using TaskManager.Model;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Add(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                var task = new TaskModel { Title = title, IsCompleted = false };
                _context.Tasks.Add(task);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                task.IsCompleted = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var tasks = _context.Tasks.ToList();
            return View(tasks);
        }
    }
}


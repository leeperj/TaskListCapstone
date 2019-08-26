using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskListCapstone6.Models;

namespace TaskListCapstone6.Controllers
{
    
    public class TaskListController : Controller
    {
        private readonly TasklistDbContext _context;

        public TaskListController(TasklistDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult AddTask()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddTask(TaskList newTask)
        {
            AspNetUsers thisUser = _context.AspNetUsers.Where(u => u.UserName == User.Identity.Name).First();
            newTask.UserId = thisUser.Id;
            _context.TaskList.Add(newTask);
            _context.SaveChanges();
            return RedirectToAction("ListTasks");
        }
        [Authorize]
        public IActionResult ListTasks()
        {
            List<TaskList> userTasks = _context.TaskList.ToList();
            return View(userTasks);
        }

        public IActionResult DeleteTask(int Id)
        {
            TaskList found = _context.TaskList.Find(Id);
            if (found != null)
            {
                _context.TaskList.Remove(found);
                _context.SaveChanges();

            }
            return RedirectToAction("ListTasks");

        }

        public IActionResult UpdateTask(int Id)
        {
            TaskList found = _context.TaskList.Find(Id);
            if (found != null)
            {
                found.Completed = "yes";

                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("ListTasks");
        }
    }
}
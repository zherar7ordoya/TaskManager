using Microsoft.AspNetCore.Mvc;
using Task = TaskManager.Models.Task;

namespace TaskManager.Controllers;

public class TaskController : Controller
{
    private static readonly List<Task> _tasks = [];
    private static int _nextId = 1;

    public IActionResult Index()
    {
        return View(_tasks);
    }

    public IActionResult Detail(int id)
    {
        Task? task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Task task)
    {
        if (ModelState.IsValid)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }
}

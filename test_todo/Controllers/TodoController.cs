using Microsoft.AspNetCore.Mvc;
using Todo.Models;

namespace Todo.Controllers;

public class TodoController : Controller
{

    public IActionResult Index()
    {
        var model = Respository.todolist;
        return View(model);
    }

    [HttpGet] //ddee truy cập dô form
    public IActionResult TodoForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TodoForm(Todo.Models.Todo _todo) //truyen len kieu gi thi no hứng kiểu đó --- ctroller /Models /View /teen bieens
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        Respository.AddTodo(_todo);
        return RedirectToAction("Index");
    }
}
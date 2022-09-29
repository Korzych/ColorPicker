using ColorPicker.Models;
using ColorPicker.Services;
using Microsoft.AspNetCore.Mvc;

namespace ColorPicker.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
    }

    [HttpGet]
    public ActionResult<List<User>> GetAll() =>
    UserService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var user = UserService.Get(id);

        if (user == null)
            return NotFound();

        return user;
    }
    /*
    [HttpPost]
    public IActionResult Create(User user)
    {
        // This code will save the pizza and return a result
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, User)
    {
        // This code will update the pizza and return a result
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // This code will delete the pizza and return a result
    }*/

    // POST action

    // PUT action

    // DELETE action
}
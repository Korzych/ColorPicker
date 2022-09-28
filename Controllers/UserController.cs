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

    // POST action

    // PUT action

    // DELETE action
}
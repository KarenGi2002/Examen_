using Microsoft.AspNetCore.Mvc;

namespace universidades.Controllers;

[ApiController]
[Route("[Controller]")]
public class homeController: ControllerBase{

  context dbcontext;

    public homeController(context db){
        dbcontext=db;

    }

    [HttpGet]
    [Route("Conndb")]
    public IActionResult Conndb(){
        dbcontext.Database.EnsureCreated();
        return Ok();
    }
}
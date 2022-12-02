using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
     [HttpPost("Login")]
    public async Task<IActionResult> Login(
        [FromBody]UsuarioDTO user

    )
    {
        
        using  context = new ();
    }
}

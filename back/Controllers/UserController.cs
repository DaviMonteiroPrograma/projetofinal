using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
     [HttpPost("Login")]
    public async Task<IActionResult> Login(
        [FromBody] Usuario user
    )
    {
        using TCCSenai context = new TCCSenai ();

        var possivelUser = context.Usuario.FirstOrDefault(u.UserId == user.UserId);

        if(possivelUser == null){
            return NotFound("Nome de Usuário inválido");
        }
        if(possivelUser.Userpass != user.Password){
            return NotFound("Senha Inválida!");
        }
    }

     [HttpPost("registro")]
    public async Task<IActionResult> Registro(
        [FromBody] Usuario user
    )
    {
        using TCCSenai context = new TCCSenai ();
        
        var repeatUserpass;

        list<string> errors = new List<string>();

        if(user.Nome.length < 5){
            errors.Add("O nome do usuário precisa conter ao menos 5 letras");

        }
        if(user.Sobrenome.length < 5){
            errors.Add("O Sobrenome do usuário precisa conter ao menos 5 letras");
        }
        if(user.Userpass.length < 5){
            errors.Add("A senha precisa conter pelo menos 5 caracteres ");

        }
        if(user.repeatUserpass != user.Userpass){
            errors.Add("As senhas não são iguais");
        }

        Usuario usuario = new Usuario();
        usuario.Name = user.Name;
        usuario.Sobrenome = user.Sobrenome;
        usuario.Userpass = user.Password;
        usuario.UserId = user.UserId;

        context.Add(usuario);
        context.Savechanges();

        return ok();
    }
      [HttpPost("Peca")]
    public Task<IActionResult>Peca(
        [FromBody] Peca peca
    )
    {
        using TCCSenai context = new TCCSenai ();

        
    }


      [HttpPost("update")]
    public IActionResult UpdateName()
    {
        throw new NotImplementedException();
    }
}

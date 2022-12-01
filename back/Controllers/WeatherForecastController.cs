using Microsoft.AspNetCore.Mvc;
using dto;
using Model;
 

namespace back.Controllers;

[ApiController]
[Route("Login")]
public class WeatherForecastController : ControllerBase
{
    [Httppost("Login")]
    public async Task<IActionResult> Login(
        [FromBody]Login email, Senha senha
        
    )
    {
        using TCCsenai context = new tccsenaicontext();

        var possibleEmail = context.email.FirstOrDefault(e => e.Email == email.Email);
        var possibleSenha = context.senha.FirstOrDefault(s => s.Senha == senha.Senha);
        if(possibleemail == nuull){
            return NotFound("Email inválido");
        }
        if(possibleSenha.senha != senha.Senha){
            return NotFound("Senha Inválida");
        }    

     
    }
    [Httppost("Registro")];
    public IActionResult Registro(
        [FromBody]Registro email, Nome nome, Sobrenome sobrenome, Senha senha, Repetirsenha repetirsenha
    )
    {
        List<String> errors = new List<String>();

        if(Nome.Length <= 2){
            errors.Add("O nome precisa de no minímo 3 letra ");
        }
        
        if(context.Nome .Any(r => r.Email == email.Email);){
            errors.Add("Esse nome já está em uso");
        }

        if(Sobrenome.Length < 5){
            errors.Add("O nome precisa de no minímo 5 letra ");
    
        }

        if(senha.Length <= 5){
            errors.Add("senha precisa ter pelo menos 5 caracteres");
        }

        if(Repetirsenha != senha){
            errors.Add("As senhas não são iguais");
        }

        if(Repetirsenha == senha){
            return ("registro completo");
        }
        Nome usuario = new nome();
        Nome.name = Registro.nome;
        Nome.Sobrenome = Registro.Sobrenome;
        Email.Senha = Senha.senha;

        context.Add(nome);
        context.SaveChanges();
        return(ok);

         [HttpPost("update")]
         public IActionResult UpdateName()
         {
            throw new NotImplementedException();
         }

        context.Add(Email);
        context.SaveChanges;
        return Ok();
        
    }
        
    

}
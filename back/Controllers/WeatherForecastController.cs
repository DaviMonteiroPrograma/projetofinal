using Microsoft.AspNetCore.Mvc;
using dto;
 

namespace back.Controllers;

using Services;
using Model;

[ApiController]
[Route("Usuario")]
public class WeatherForecastController : ControllerBase
{
    [Httppost("Login")]
    public async Task<IActionResult> Login(
        [FromBody]Login email,
        [FromServices]TokenService services
    )
    {
        using TCCsenai context = new tccsenaicontext();

        var possibleEmail = context.email.FirstOrDefault(e => e.Email == email.Email);

        if(possibleemail == nuull){
            return NotFound("Email inválido");
        }
        if(possibleSenha.senha != email.senha){
            return NotFound("Senha Inválida");
        }    

        var token = await service.CreateToken(possibleemail);
        return Ok(token.Value);
    }
    [Httppost("Registro")];
    public IActionResult Registro(
        [FromBody]Registro email
        )
    {
        using TCCsenai context = new tccsenaicontext();

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
        
        context.Add(Email);
        context.SaveChanges;

        return Ok();
        
    }


    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

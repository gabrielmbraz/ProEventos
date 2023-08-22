using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
        
    }

    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento(){
            EventoID = 1,
            Tema = "Angular e .NET 6",
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            QtdePessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
        },
        new Evento(){
            EventoID = 2,
            Tema = "Angular e suas novidades",
            Local = "São Paulo",
            Lote = "2º Lote",
            QtdePessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.png"
        }
    };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoID == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put id {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete id {id}";
    }
}

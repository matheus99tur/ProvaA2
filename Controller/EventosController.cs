using System;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/evento")]
public class EventosController : ControllerBase
{
    private readonly IEventoRepository _eventoRepository;
    public EventosController(IEventoRepository eventoRepository)
    {
        _eventoRepository = eventoRepository;
    }
    [HttpPost("cadastrar")]
    [Authorize(Roles = "adiministrador")]
    public IActionResult Cadastrar([FromBody] Evento evento)
    {
        
       _eventoRepository.Cadastrar(evento);
        return Created("", evento);
    }
    [HttpGet("listar")]
    public IActionResult Listar()
    {
        return Ok(_eventoRepository.Listar());
    }


    
}


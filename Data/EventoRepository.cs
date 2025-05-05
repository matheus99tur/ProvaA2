using System;
using API.Models;

namespace API.Data;

public class EventoRepository : IEventoRepository
{
    private readonly AppDataContext _context;
    public EventoRepository (AppDataContext context)
    {
        _context = context;
    }
    public void Cadastrar(Evento evento)
    {
        _context.Eventos.Add(evento);
        _context.SaveChanges();
    }

    public List<Evento> Listar()
    {
       return _context.Eventos.ToList();
    }
}

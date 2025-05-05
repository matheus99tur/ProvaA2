using System;
using API.Models;

namespace API.Data;

public interface IEventoRepository
{
    void Cadastrar(Evento evento);
    List<Evento> Listar();
}


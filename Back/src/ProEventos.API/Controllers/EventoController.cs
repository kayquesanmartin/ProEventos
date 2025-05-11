using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                    EventoId = 1,
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "Angular e .NET",
                    QtdPessoas = 250,
                    Lote = "1º Lote",
                    ImagemURL = "http://www.brasil.com.br/imagem.png"
                },
                new Evento()
                {
                    EventoId = 2,
                    Local = "Rio de Janeiro",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Tema = "Angular e suas novidades",
                    QtdPessoas = 350,
                    Lote = "2º Lote",
                    ImagemURL = "http://www.brasil.com.br/imagem.png"
                }
            };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"exemplo de delete com id = {id}";
        }
    }
}

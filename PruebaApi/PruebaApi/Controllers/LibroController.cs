using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LibroController : ControllerBase
    {
        private readonly ILogger<LibroController> _logger;

        private static List<LibroDTO> Libros = new List<LibroDTO>()
        {
            new LibroDTO()
            {
                ISBN="123456",
                Id=1,
                NumPag=200,
                Titulo="Pinocchio"
            },
            new LibroDTO()
            {
                ISBN="654321",
                Id=2,
                NumPag=123,
                Titulo="The Hunger Games"
            }
        };

        public LibroController(ILogger<LibroController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<LibroDTO> Get()
        {
            return Libros;
        }

        [HttpGet]
        public LibroDTO Get(int id)
        {
            return Libros.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public LibroDTO Post([FromBody] LibroDTO libro)
        {
            if (Libros.Any(x => x.Id == libro.Id))
            {
                return null;
            }
            Libros.Add(libro);
            return libro;
        }

        [HttpPut]
        public LibroDTO Put(LibroDTO libro,int id)
        {
            if (id != libro?.Id)
            {
                return null;
            }

            LibroDTO? libroBBDD = Libros.FirstOrDefault(x => x.Id == libro.Id);
            if (libroBBDD == null)
            {
                return null;
            }
            libroBBDD.ISBN= libro.ISBN;
            libroBBDD.NumPag= libro.NumPag;
            libroBBDD.Titulo= libro.Titulo;

            return libroBBDD;
        }
        [HttpDelete]
        public bool Remove(int id)
        {
            LibroDTO? libroBBDD = Libros.FirstOrDefault(x => x.Id == id);
            if (libroBBDD == null)
            {
                return false;
            }
            
            return Libros.Remove(libroBBDD);
        }

    }
}

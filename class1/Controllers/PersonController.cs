using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace class1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
       
        // POST api/<PersonController>
        [HttpPost]
        public List<Persona> GetPersonas(Persona persona)
        {
            List<Persona> lista = new List<Persona>();
            for (int i = 0; i < 10;i++) 
            {
                lista.Add(persona);  
            }
            return lista;
        }

    }
}

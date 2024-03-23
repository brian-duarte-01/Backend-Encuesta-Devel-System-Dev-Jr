using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Repositorie;
using Backend_Encuesta_Devel_System.Request;
using Backend_Encuesta_Devel_System.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private UsuarioRepositorie ur = new UsuarioRepositorie(new UsuarioService());

        [HttpGet]
        public ActionResult get()
        {
            return ur.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string nick="")
        {
            return ur.getBuscar(nick);
        }


        [HttpGet]
        [Route("Count")]
        public ActionResult getCount()
        {
            return ur.getCount();
        }

        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return ur.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] UsuarioRequest request)
        {
            return ur.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] UsuarioRequest request)
        {
            return ur.put(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return ur.delete(id);
        }
    }
}

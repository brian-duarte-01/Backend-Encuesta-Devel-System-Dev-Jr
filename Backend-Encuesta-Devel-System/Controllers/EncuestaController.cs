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
    public class EncuestaController : ControllerBase
    {

        private EncuestaRepositorie er = new EncuestaRepositorie(new EncuestaService());

        [HttpGet]
        public ActionResult get()
        {
            return er.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string usuario="", string encuestador = "")
        {
            return er.getBuscar(usuario, encuestador);
        }


        [HttpGet]
        [Route("Count")]
        public ActionResult getCount()
        {
            return er.getCount();
        }


        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return er.getVisualizar(id);
        }


        [HttpPost]
        public ActionResult post([FromBody] EncuestaRequest request)
        {
            return er.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] EncuestaRequest request)
        {
            return er.put(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return er.delete(id);
        }
    }
}

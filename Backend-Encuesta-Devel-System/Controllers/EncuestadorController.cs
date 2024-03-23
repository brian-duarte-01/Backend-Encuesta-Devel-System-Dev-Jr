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
    public class EncuestadorController : ControllerBase
    {

        private EncuestadorRepositorie er = new EncuestadorRepositorie(new EncuestadorService());


        [HttpGet]
        public ActionResult get()
        {
            return er.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string primer_nombre = "", string primer_apellido="")
        {
            return er.getBuscar(primer_nombre, primer_apellido);
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
        public ActionResult post([FromBody] EncuestadorRequest request)
        {
            return er.post(request);    
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] EncuestadorRequest request)
        {
            return er.put(id,request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return er.delete(id);
        }
    }
}

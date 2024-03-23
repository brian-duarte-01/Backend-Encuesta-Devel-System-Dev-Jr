using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Interface
{
    public interface IEncuesta
    {
        public ActionResult get();
        public ActionResult getBuscar(string usuario, string encuestador);
        public ActionResult getVisualizar(int id);
        public ActionResult getCount();
        public ActionResult post([FromBody] Request.EncuestaRequest request);
        public ActionResult put(int id, [FromBody] Request.EncuestaRequest request);
        public ActionResult delete(int id);
    }
}

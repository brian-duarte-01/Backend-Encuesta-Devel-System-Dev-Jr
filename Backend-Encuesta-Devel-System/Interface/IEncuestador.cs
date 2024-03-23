using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Interface
{
    public interface IEncuestador
    {
        public ActionResult get();
        public ActionResult getBuscar(string primer_nombre, string primer_apellido);
        public ActionResult getVisualizar(int id);
        public ActionResult getCount();
        public ActionResult post([FromBody] Request.EncuestadorRequest request);
        public ActionResult put(int id, [FromBody] Request.EncuestadorRequest request);
        public ActionResult delete(int id);

    }
}

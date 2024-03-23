using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Interface
{
    public interface IUsuario
    {
        public ActionResult get();
        public ActionResult getBuscar(string nick);
        public ActionResult getVisualizar(int id);
        public ActionResult getCount();
        public ActionResult post([FromBody] Request.UsuarioRequest request);
        public ActionResult put(int id, [FromBody] Request.UsuarioRequest request);
        public ActionResult delete(int id);
    }
}

using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Repositorie
{
    public class UsuarioRepositorie 
    {

        public IUsuario iusuario;

        public UsuarioRepositorie(IUsuario _iusuario)
        {
            this.iusuario = _iusuario;
        }

        public ActionResult get()
        {
            return this.iusuario.get();
        }

        public ActionResult getBuscar(string nick)
        {
            return this.iusuario.getBuscar(nick);
        }

        public ActionResult getCount()
        {
            return this.iusuario.getCount();
        }

        public ActionResult getVisualizar(int id)
        {
            return this.iusuario.getVisualizar(id);
        }

        public ActionResult post([FromBody] UsuarioRequest request)
        {
            return this.iusuario.post(request);
        }

        public ActionResult put(int id, [FromBody] UsuarioRequest request)
        {
            return this.iusuario.put(id, request);
        }

        public ActionResult delete(int id)
        {
            return this.iusuario.delete(id);
        }
    }
}

using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Repositorie
{
    public class EncuestaRepositorie 
    {

        public IEncuesta iencuesta;

        public EncuestaRepositorie(IEncuesta _iencuesta)
        {
            this.iencuesta = _iencuesta;
        }

        public ActionResult get()
        {
            return this.iencuesta.get();
        }

        public ActionResult getBuscar(string usuario, string encuestador)
        {
            return this.iencuesta.getBuscar(usuario, encuestador);  
        }

        public ActionResult getCount()
        {
            return this.iencuesta.getCount();
        }

        public ActionResult getVisualizar(int id)
        {
            return this.iencuesta.getVisualizar(id);
        }

        public ActionResult post([FromBody] EncuestaRequest request)
        {
            return this.iencuesta.post(request);
        }

        public ActionResult put(int id, [FromBody] EncuestaRequest request)
        {
            return this.iencuesta.put(id, request);
        }

        public ActionResult delete(int id)
        {
            return this.iencuesta.delete(id);
        }
    }
}

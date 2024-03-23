using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Repositorie
{
    public class EncuestadorRepositorie 
    {

        public IEncuestador iencuestador;

        public EncuestadorRepositorie(IEncuestador _iencuestador)
        {
            this.iencuestador = _iencuestador;
        }
      

        public ActionResult get()
        {
            return this.iencuestador.get();
        }

        public ActionResult getBuscar(string primer_nombre, string primer_apellido)
        {
            return this.iencuestador.getBuscar(primer_nombre, primer_apellido);
        }

        public ActionResult getCount()
        {
            return this.iencuestador.getCount();
        }

        public ActionResult getVisualizar(int id)
        {
            return this.iencuestador.getVisualizar(id);
        }

        public ActionResult post([FromBody] EncuestadorRequest request)
        {
            return this.iencuestador.post(request);
        }

        public ActionResult put(int id, [FromBody] EncuestadorRequest request)
        {
            return this.iencuestador.put(id,request);
        }

        public ActionResult delete(int id)
        {
            return this.iencuestador.delete(id);
        }
    }
}

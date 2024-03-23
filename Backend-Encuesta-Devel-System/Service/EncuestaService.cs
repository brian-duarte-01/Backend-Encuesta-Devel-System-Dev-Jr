using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Service
{
    public class EncuestaService : ControllerBase, IEncuesta
    {
        

        public ActionResult get()
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sql = db.Encuesta.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getBuscar(string usuario, string encuestador)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Encuesta
                        where sql.EUsuario.Contains(usuario) || sql.EEncuestador.Contains(encuestador)
                        select sql
                        ).ToList();

                    var Sql = db.Encuesta.ToList();

                    if (usuario =="" || encuestador=="")
                    {
                        return Ok(Sql);
                    }
                    else if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontro ninguna encuesta, Vuelve a intentarlo!!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getCount()
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sql = db.Encuesta.Count();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getVisualizar(int id)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Encuesta
                        where sql.IdEncuesta == id
                        select sql
                        ).ToList();

                    if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontro ninguna encuesta con ese Id, Vuelve a intentarlo!!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult post([FromBody] EncuestaRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    DateTime fecha = DateTime.Now;

                    Models.Encuestum encuesta = new Models.Encuestum();
                    encuesta.ENombreEncuesta = request.e_nombre_encuesta;
                    encuesta.EDescripcion = request.e_descripcion;

                    encuesta.ETituloPregunta1 = request.e_titulo_pregunta_1;
                    encuesta.EDescripPregunta1 = request.e_descrip_pregunta_1;
                    encuesta.ERespuesta1 = request.e_respuesta_1;

                    encuesta.ETituloPregunta2 = request.e_titulo_pregunta_2;
                    encuesta.EDescripPregunta2 = request.e_descrip_pregunta_2;
                    encuesta.ERespuesta2 = request.e_respuesta_2;

                    encuesta.ETituloPregunta3 = request.e_titulo_pregunta_3;
                    encuesta.EDescripPregunta3 = request.e_descrip_pregunta_3;
                    encuesta.ERespuesta3 = request.e_respuesta_3;

                    encuesta.ETituloPregunta4 = request.e_titulo_pregunta_4;
                    encuesta.EDescripPregunta4 = request.e_descrip_pregunta_4;
                    encuesta.ERespuesta4 = request.e_respuesta_4;

                    encuesta.ETituloPregunta5 = request.e_titulo_pregunta_5;
                    encuesta.EDescripPregunta5 = request.e_descrip_pregunta_5;
                    encuesta.ERespuesta5 = request.e_respuesta_5;

                    encuesta.EUsuario = request.e_usuario;
                    encuesta.EEncuestador = request.e_encuestador;
                    encuesta.EFecha = Convert.ToString(fecha.ToLocalTime());
                    db.Encuesta.Add(encuesta);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] EncuestaRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Encuestum encuesta = db.Encuesta.Find(id);
                    encuesta.ENombreEncuesta = request.e_nombre_encuesta;
                    encuesta.EDescripcion = request.e_descripcion;

                    encuesta.ETituloPregunta1 = request.e_titulo_pregunta_1;
                    encuesta.EDescripPregunta1 = request.e_descrip_pregunta_1;
                    encuesta.ERespuesta1 = request.e_respuesta_1;

                    encuesta.ETituloPregunta2 = request.e_titulo_pregunta_2;
                    encuesta.EDescripPregunta2 = request.e_descrip_pregunta_2;
                    encuesta.ERespuesta2 = request.e_respuesta_2;

                    encuesta.ETituloPregunta3 = request.e_titulo_pregunta_3;
                    encuesta.EDescripPregunta3 = request.e_descrip_pregunta_3;
                    encuesta.ERespuesta3 = request.e_respuesta_3;

                    encuesta.ETituloPregunta4 = request.e_titulo_pregunta_4;
                    encuesta.EDescripPregunta4 = request.e_descrip_pregunta_4;
                    encuesta.ERespuesta4 = request.e_respuesta_4;

                    encuesta.ETituloPregunta5 = request.e_titulo_pregunta_5;
                    encuesta.EDescripPregunta5 = request.e_descrip_pregunta_5;
                    encuesta.ERespuesta5 = request.e_respuesta_5;

                    encuesta.EUsuario = request.e_usuario;
                    encuesta.EEncuestador = request.e_encuestador;
                    db.Entry(encuesta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult delete(int id)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Encuestum encuesta = db.Encuesta.Find(id);
                    db.Encuesta.Remove(encuesta);
                    db.SaveChanges();
                    return Ok("Se elimino correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

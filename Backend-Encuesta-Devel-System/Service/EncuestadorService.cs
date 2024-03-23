using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Backend_Encuesta_Devel_System.Service
{
    public class EncuestadorService : ControllerBase, IEncuestador
    {
        

        public ActionResult get()
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sql = db.Encuestadors.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getBuscar(string primer_nombre, string primer_apellido)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Encuestadors
                        where sql.EPrimerNombre.Contains(primer_nombre) && sql.EPrimerApellido.Contains(primer_apellido)
                        select sql
                        ).ToList();

                    var Sql = db.Encuestadors.ToList();

                    if (primer_nombre=="" && primer_apellido=="")
                    {
                        return Ok(Sql);
                    }
                    else if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontró datos del encuestador, Vuelva a intentar!!");
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
                    var sql = db.Encuestadors.Count();
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
                        from sql in db.Encuestadors
                        where sql.IdEncuestador == id
                        select sql
                        ).ToList();

                    if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontró ningún dato, vuelva a intentar!!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult post([FromBody] EncuestadorRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Encuestador encuestador = new Models.Encuestador();
                    encuestador.EPrimerNombre = request.e_primer_nombre;
                    encuestador.ESegundoNombre = request.e_segundo_nombre;
                    encuestador.EPrimerApellido = request.e_primer_apellido;
                    encuestador.ESegundoApellido = request.e_segundo_apellido;
                    encuestador.ETelefono = request.e_telefono;
                    encuestador.Correo = request.e_correo;
                    db.Encuestadors.Add(encuestador);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] EncuestadorRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Encuestador encuestador = db.Encuestadors.Find(id);
                    encuestador.EPrimerNombre = request.e_primer_nombre;
                    encuestador.ESegundoNombre = request.e_segundo_nombre;
                    encuestador.EPrimerApellido = request.e_primer_apellido;
                    encuestador.ESegundoApellido = request.e_segundo_apellido;
                    encuestador.ETelefono = request.e_telefono;
                    encuestador.Correo = request.e_correo;
                    db.Entry(encuestador).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                    Models.Encuestador encuestador = db.Encuestadors.Find(id);
                    db.Encuestadors.Remove(encuestador);
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

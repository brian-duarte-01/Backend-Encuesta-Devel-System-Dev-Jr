using Backend_Encuesta_Devel_System.Interface;
using Backend_Encuesta_Devel_System.Request;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Encuesta_Devel_System.Service
{
    public class UsuarioService : ControllerBase, IUsuario
    {
        

        public ActionResult get()
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sql = db.Usuarios.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getBuscar(string nick)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Usuarios
                        where sql.UNick.Contains(nick)
                        select sql
                        ).ToList();

                    var Sql = db.Usuarios.ToList();

                    if (nick == "")
                    {
                        return Ok(Sql);
                    }
                    else if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontró ningún usuario, Vuelve a intentarlo!!");
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
                    var sql = db.Usuarios.Count();
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
                    var sqlQuery = (
                        from sql in db.Usuarios
                        where sql.IdUsuario == id
                        select sql
                        ).ToList();

                    if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontró ningún usuario, Vuelve a intentarlo!!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult post([FromBody] UsuarioRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Usuario usuario = new Models.Usuario();
                    usuario.UNick = request.u_nick;
                    usuario.UPassword = request.u_password;
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] UsuarioRequest request)
        {
            try
            {
                using (Models.EncuestaDevelContext db = new Models.EncuestaDevelContext())
                {
                    Models.Usuario usuario = db.Usuarios.Find(id);
                    usuario.UNick = request.u_nick;
                    usuario.UPassword = request.u_password;
                    db.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                    Models.Usuario usuario = db.Usuarios.Find(id);
                    db.Usuarios.Remove(usuario);
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

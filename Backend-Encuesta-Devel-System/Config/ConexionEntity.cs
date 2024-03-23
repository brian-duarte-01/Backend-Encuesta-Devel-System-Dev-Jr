namespace Backend_Encuesta_Devel_System.Config
{
    public class ConexionEntity
    {
        protected string server {  get; set; }
        protected string dataBase { get; set; }

        protected ConexionEntity() 
        {
            this.server = ".";
            this.dataBase = "Encuesta_Devel";
        }

    }
}

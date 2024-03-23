namespace Backend_Encuesta_Devel_System.Config
{
    public class Conexion: ConexionEntity
    {
        private static Conexion instance = null;
        public string cadenaConexion { get; set; }

        protected Conexion()
        {
            this.cadenaConexion = "server="+server+"; database="+dataBase+"; integrated security=true; TrustServerCertificate=true;";
        }

        public static Conexion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Conexion();
                }
                return instance;
            }
        }
    }
}

using System.Configuration;

namespace Prueba02.Datos
{
    public class Conexion
    {
        public static string BaseDatos
        {
            get { return ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private string BaseDato;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.BaseDato = "BD_Prana";
            this.Servidor = "DESKTOP-G1GT125\\SQLEXPRESS";
            this.Usuario = "Prana";
            this.Clave = "123456";
            this.Seguridad = false;
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.BaseDato + ";";
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch(Exception e)
            {
                Cadena = null;
                throw e;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if(Con== null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}

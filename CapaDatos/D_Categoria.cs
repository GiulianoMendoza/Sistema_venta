using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capaentidad;

namespace CapaDatos
{
    public class D_Categoria 
    {
        public DataTable Listado_categoria(string ctexto)//metodo que necesito para saber que tiene mi tabla en mi bd
        {
            SqlDataReader resultado; //instancio sql data
            DataTable Tabla = new DataTable(); //nueva variable de tabla tipo datatable
            SqlConnection Sqlcon = new SqlConnection(); //hago la conexion de sql
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion(); //utilizo de la clase conexion los 2 metodos, instancia una conexion y creala.
                SqlCommand comando = new SqlCommand("Usp_listado_ca", Sqlcon);  //instancia de un objeto SqlCommand con el nombre del procedimiento almacenado y la conexión asociada a él.
                comando.CommandType = CommandType.StoredProcedure; //el tipo de comando como un procedimiento almacenado
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value= ctexto; //comando va a recibir por parametro ctexto de tipo varchar y le asigna ctexto string
                Sqlcon.Open(); //una vez cargado y generado la conexion, abrir la conexion. 
                resultado = comando.ExecuteReader(); //(sqldatareader)se utiliza para leer y recuperar los datos resultantes de la consulta y con excutereader lo leemos.
                Tabla.Load(resultado); //carga los datos obtenidos de la consulta ejecutada en resultado
                return Tabla; //retorno la tabla
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) //si la base se encuentra abierta, que se cierre
                { 
                    Sqlcon.Close();//se cierra la conexion
                }
            }
        }
        public string Guardar_categoria(int nOpcion, E_categoria oCat, int cPrecio) 
        {
            string rpta = "";
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion(); //utilizo de la clase conexion los 2 metodos, instancia una conexion y creala.
                SqlCommand comando = new SqlCommand("Usp_guardar_ca", Sqlcon); //instancia de un objeto SqlCommand con el nombre del procedimiento almacenado y la conexión asociada a él.
                comando.CommandType = CommandType.StoredProcedure; //el tipo de comando como un procedimiento almacenado
                comando.Parameters.Add("nOpcion", SqlDbType.Int).Value= nOpcion; //lo que le vamos asignar en sql por el formulario, es decir value = nopcion lo que escribamos y el parametro lo que escribe en la bd
                comando.Parameters.Add("nCodigo_ca", SqlDbType.Int).Value = oCat.Codigo_ca; //lo que le vamos asignar en sql por el formulario, es decir value = nopcion lo que escribamos y el parametro lo que escribe en la bd
                comando.Parameters.Add("cPrecio", SqlDbType.Int).Value = cPrecio;//lo que le vamos asignar en sql por el formulario, es decir value = nopcion lo que escribamos y el parametro lo que escribe en la bd
                comando.Parameters.Add("cDescripcion_ca", SqlDbType.VarChar).Value = oCat.Descripcion;//lo que le vamos asignar en sql por el formulario, es decir value = nopcion lo que escribamos y el parametro lo que escribe en la bd
                Sqlcon.Open(); //una vez cargado y generado la conexion, abrir la conexion.
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar datos"; //la variable rpta recibe la peticion de si es igual a 1, devuelveme ok caso contrario (:) no se pudo...
            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if(Sqlcon.State == ConnectionState.Open) //si la base se encuentra abierta, que se cierre
                { 
                    Sqlcon.Close();  //se cierra la conexion
                }
            }
            return rpta;
        }
    }
}

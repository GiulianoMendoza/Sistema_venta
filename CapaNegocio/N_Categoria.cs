using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Capaentidad;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class N_Categoria
    {
        
       public static DataTable Listado_categoria(string ctexto)
        {
            D_Categoria datos = new D_Categoria(); //creo un objeto de tipo d_categoria de la capa dato
            return datos.Listado_categoria(ctexto); //retorno el metodo listado de categoria de la capa dato

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capaentidad;
using CapaNegocio;

namespace Prana
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }
        #region "mis metodos"
        private void Formato_ca()
        {
            Dgv_principal.Columns[0].Width = 100;  //defino ancho a la columna 0 en el datagrid
            Dgv_principal.Columns[0].HeaderText = "CODIGO"; //redefino que contenido va aparecer en la columna 0 en el datagrid
            Dgv_principal.Columns[1].Width = 150; //defino ancho a la columna 1 en el datagrid
            Dgv_principal.Columns[1].HeaderText = "CATEGORIA"; //redefino que contenido va aparecer en la columna 1 en el datagrid

        }

        private void Listado_categoria(string ctexto) 
        {
            try
            {
                Dgv_principal.DataSource = N_Categoria.Listado_categoria(ctexto); //establece en el datagrid lo contenido en el metodo de la clase n_categoria de la capa negocio
                this.Formato_ca(); //hace uso de la funcion formato_ca para darle formato al datagrid
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //envia un mensaje de error y muestra de donde proviene
            }
        }
        #endregion
        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_categoria("%");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

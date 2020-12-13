using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaUI
{
    public partial class Form1 : Form
    {
        private bool Editar = false;
        private String idProducto = null;

        CN_Productos objectCN = new CN_Productos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            CN_Productos objectCN2 = new CN_Productos();
            dataGridView1.DataSource = objectCN2.MostrarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                objectCN.InsertarProducto(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                MessageBox.Show("Se registro Correctamente");
                Limpiar();
                MostrarProductos();
            }
            if(Editar == true)
            {
                try
                {
                    objectCN.EditarProducto(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, idProducto);
                    MessageBox.Show("Se modifico Correctamente");
                    MostrarProductos();
                    Limpiar();
                    Editar = false;
                }catch(Exception e2) { throw e2; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                //ponemos los atributos como esta en la base de datos
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Ocurrio un error seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    idProducto = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    objectCN.EliminarProducto(idProducto);
                    MessageBox.Show("Eliminado con Exito");
                    MostrarProductos();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Selecciona una fila");
                }
            }catch(Exception e2) { throw e2; }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            idProducto = null;
        }
    }
}

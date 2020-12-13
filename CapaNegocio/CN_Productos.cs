using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objectCD = new CD_Productos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.Mostrar();
            return tabla;
        }

        public void InsertarProducto(string Nombre, string Descripcion, string Marca, string Precio, string Stock)
        {
            //convercion para registrar a datos
            objectCD.Insertar(Nombre, Descripcion, Marca, Convert.ToDouble(Precio), Convert.ToInt32(Stock));
        }

        public void EditarProducto(string Nombre, string Descripcion, string Marca, string Precio, string Stock, string idProducto)
        {
            objectCD.Modificar(Nombre, Descripcion, Marca, Convert.ToDouble(Precio), Convert.ToInt32(Stock), Convert.ToInt32(idProducto));
        }

        public void EliminarProducto(string idProducto)
        {
            objectCD.Eliminar(Convert.ToInt32(idProducto));
        }
    }
}

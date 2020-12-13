using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion con = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();


        public DataTable Mostrar()
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SELECT * FROM Productos";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock)
        {
            try
            {
                cmd.Connection = con.AbrirConexion();
                cmd.CommandText = "INSERT INTO Productos VALUES('" + nombre + "','" + descripcion + "','" + marca + "','" + precio + "','" + stock + "')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }catch(Exception e) { throw e; }
        }

        public void Eliminar(int idProducto)
        {
            try
            {
                cmd.Connection = con.AbrirConexion();
                cmd.CommandText = "DELETE FROM Productos WHERE id = @p0";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p0", idProducto);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }catch(Exception e) { throw e; }
        }

        public void Modificar(string nombre, string descripcion, string marca, double precio, int stock, int idProducto)
        {
            try
            {
                cmd.Connection = con.AbrirConexion();
                cmd.CommandText = "UPDATE Productos SET Nombre = @p1, Descripcion = @p2, Marca = @p3, Precio = @p4, Stock = @p5 WHERE id = @p0";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p1", nombre);
                cmd.Parameters.AddWithValue("@p2", descripcion);
                cmd.Parameters.AddWithValue("@p3", marca);
                cmd.Parameters.AddWithValue("@p4", precio);
                cmd.Parameters.AddWithValue("@p5", stock);
                cmd.Parameters.AddWithValue("@p0", idProducto);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                /*VERSION 2 
                var QUERY = new SqlCommand ("UPDATE Productos SET Nombre = @p1, Descripcion = @p2, Marca = @p3, Precio = @p4, Stock = @p5 WHERE id = @p0", con.AbrirConexion());
                QUERY.Parameters.AddWithValue("@p1", nombre);
                QUERY.Parameters.AddWithValue("@p2", descripcion);
                QUERY.Parameters.AddWithValue("@p3", marca);
                QUERY.Parameters.AddWithValue("@p4", precio);
                QUERY.Parameters.AddWithValue("@p5", stock);
                QUERY.Parameters.AddWithValue("@p0", idProducto);
                QUERY.ExecuteNonQuery();
                cmd.Parameters.Clear();
                */

            }
            catch (Exception e) { throw e; }
        }
    }
}

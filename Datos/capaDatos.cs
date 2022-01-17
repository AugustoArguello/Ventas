using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public class capaDatos
    {
        
        static  string conexion = "Data Source=DESKTOP-A59GTNO;Initial Catalog=Punto_de_venta;Integrated Security=True";
        SqlConnection conexionsql = new SqlConnection(conexion);
       

        public int consultalogin(string usuario, string contraseña)
        {
            int count;
            conexionsql.Open();
            string query = "select count(*) from usuario where Usuario = '" + usuario + "' and Contaseña = '" + contraseña + "'";
            SqlCommand comando = new SqlCommand(query, conexionsql);
            count = Convert.ToInt32(comando.ExecuteScalar());
            conexionsql.Close();
            return count;

        }

        public DataTable tablagrid()
        {
            string consultatabla = "select * from Proveedores";
            SqlCommand comando = new SqlCommand(consultatabla, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public void insertar(string nombre, string telefono, string ubicacion, string email, string producto, string codigopostal)
        {
            conexionsql.Open();
            string cargar = "insert into Proveedores (nombre,telefono,ubicacion,email,producto,codigopostal) values ('" +nombre + "','" + telefono + "','" + ubicacion + "','" + email + "','" + producto + "','" + codigopostal + "')";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }
        public void modificar(string nombre, string telefono, string ubicacion, string email, string producto, string codigopostal, string modificar)
        {
            conexionsql.Open();
            string cargar = "update Proveedores set  nombre = '" + nombre + "', telefono = '"+telefono+"', ubicacion = '"+ubicacion+"', email = '"+email+"', producto = '"+producto+"', codigopostal = '"+codigopostal+"' where nombre = '"+modificar+"'";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }

        public void Borrar(string nombre)
        {
            conexionsql.Open();
            string cargar = "delete from Proveedores where nombre ='"+nombre+"'";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }

        //comandos ventana Usuarios//

        public DataTable tablaCliente()
        {
            string consultatabla = "select *, concat(Codcliente,Nombre,Apellido,Telefono,Codpostal) as info from Clientes";
            SqlCommand comando = new SqlCommand(consultatabla, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public void insertarcliente(string nombre, string apellido, string telefono, string codigopostal)
        {
            conexionsql.Open();
            string cargar = "insert into Clientes (Nombre,Apellido,telefono,codigopostal) values ('" + nombre + "','" + apellido + "','" + telefono + "','" + codigopostal + "')";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }
        public void modificarcliente(string nombre, string apellido, string telefono, string codigopostal, string modificar)
        {
            conexionsql.Open();
            string cargar = "update Clientes set  Nombre = '" + nombre + "', Apellido = '" + apellido + "', Telefono = '" + telefono + "', Codpostal = '" + codigopostal + "'  where Nombre = '" + modificar + "'";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }

        public void borrarcliente(string nombre)
        {
            conexionsql.Open();
            string cargar = "delete from Clientes where nombre ='" + nombre + "'";
            SqlCommand comando = new SqlCommand(cargar, conexionsql);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            comando.ExecuteNonQuery();
            conexionsql.Close();

        }


    }

}

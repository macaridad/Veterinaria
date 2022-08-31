using FormVet.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVet.datos
{
    internal class AyudanteBD
    {
        private SqlConnection conexion;
        
        public AyudanteBD()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-N4T5GVQ\SQLEXPRESS;Initial Catalog = Veterinaria; Integrated Security = True");
        }

        public DataTable EjecutarConsultaSql(string sp)
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand(sp, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public int EjecutarSPABM(string sp, Mascota oMascota, Atencion oAtencion, Cliente oCliente)
        {
            int filasAfectadas = 0;
            
            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            try
            {
                SqlCommand comando = new SqlCommand(sp, conexion);
                comando.Transaction = transaccion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", oMascota.NombreM);
                comando.Parameters.AddWithValue("@edad", oMascota.Edad);
                comando.Parameters.AddWithValue("@tipo", oMascota.Tipo.ID);
                comando.Parameters.AddWithValue("@codCliente", oCliente.CodigoC);
                comando.Parameters.AddWithValue("@fecha", oAtencion.Fecha);
                comando.Parameters.AddWithValue("@descripcion", oAtencion.Descripcion);
                comando.Parameters.AddWithValue("@importe", oAtencion.Importe);
                filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    transaccion.Commit();
                }
            }
            catch (SqlException except)
            {
                if (transaccion != null)
                    transaccion.Rollback();
            }
            finally //se hace siempre. Se ejecuta siempre, independientemente si hubo un error o no
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return filasAfectadas;
        }

        //public DataTable CargarTipos()
        //{
        //    DataTable tabla =  new DataTable();
        //    cnn.Open();
        //    cmd = new SqlCommand("sp_cargar_tipos", cnn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    tabla.Load(cmd.ExecuteReader());
        //    cnn.Close();
        //    return tabla;
        //}
        //public DataTable CargarClientes()
        //{
        //    DataTable tabla = new DataTable();
        //    cnn.Open();
        //    cmd = new SqlCommand("sp_cargar_clientes", cnn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    tabla.Load(cmd.ExecuteReader());
        //    cnn.Close();
        //    return tabla;
        //}
    }
}

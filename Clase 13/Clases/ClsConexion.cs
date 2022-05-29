using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13.Clases
{
    public class ClsConexion
    {
        private string NombreServidor = "LAPTOP-HOT5RD3D";
        private string NombreBaseDatos = "Programacion1";

        public SqlConnection conexion;

        private String CadenaConexion { get;}

        public ClsConexion()
        {
            CadenaConexion = $"Data Source ={NombreServidor};Initial Catalog={NombreBaseDatos};Integrated Security=True";
        }

        /// <summary>
        /// Metodo para ejecutar una consulta de SQL y devuelve un Data Table
        /// </summary>
        /// <param name="ConsultaSql"></param>
        /// <returns></returns>

        public DataTable consultaTablaDirecta(String ConsultaSql)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataReader dr;
                    SqlCommand comm = new SqlCommand(ConsultaSql, conexion);
                    dr= comm.ExecuteReader();
                    var datatable = new DataTable();
                    datatable.Load(dr);
                    return datatable;
                }catch (Exception ex)
                {
                    Console.WriteLine("Error en consulta directa: DataTable"+ex.Message);
                    return null;
                }
            }
        }


        public int EjecutarSQLDirecto(string instruccionSQL)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                int status = -1;
                try
                {
                    conexion.Open();
                    SqlCommand comm = new SqlCommand(instruccionSQL, conexion);
                    status = comm.ExecuteNonQuery();
                    return status;
                }
                catch (Exception)
                {
                    return status;

                }
            }           
        }

    }
}

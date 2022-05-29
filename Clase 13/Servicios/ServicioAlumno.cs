using Clase_13.Clases;
using Clase_13.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13.Servicios
{
    public  class ServicioAlumno
    {
        public DataTable ConsultaSQL(string consulta)
        {
            ClsConexion cone = new ClsConexion();

            DataTable resp = cone.consultaTablaDirecta(consulta);

            return resp;
        }


        public int crearAlumno(MdAlumno alu)
        {
            ClsConexion comm = new ClsConexion();
            string instruccion = $"insert into tb_alumnos (carnet, nombre, correo, clase, seccion) values('{alu.carnet}','{alu.nombre}','{alu.correo}','{alu.clase}','{alu.seccion}')";
            return comm.EjecutarSQLDirecto(instruccion);
        }

        public MdAlumno ObtenerAlumno(string carnet)
        {
            ClsConexion conn = new ClsConexion();
            MdAlumno alu = new MdAlumno();

            DataTable resp = conn.consultaTablaDirecta($"select * from tb_alumnos where carnet ='{carnet}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    alu.idAlumno = Convert.ToInt32(item["idAlumno"]);
                    alu.carnet = item["carnet"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.seccion = item["seccion"].ToString();
                    alu.clase = item["clase"].ToString();
                    alu.correo = item["correo"].ToString();
                }
                return alu;
            }
            else
            {
                return null;
            }
        }


        public int actualizarAlumno(MdAlumno alu)
        {
            ClsConexion comm = new ClsConexion();
            string instruccion = $"update tb_alumnos set nombre = '{alu.nombre}',correo = '{alu.correo}',clase = '{alu.clase}',seccion= '{alu.seccion}', parcial1 = '{alu.parcial1}', parcial2 = '{alu.parcial2}', parcial3 = '{alu.parcial3}' where carnet='{alu.carnet}'";
            return comm.EjecutarSQLDirecto(instruccion);
        }


        public int eliminarAlumno(string carnet)
        {
            ClsConexion comm = new ClsConexion();
            string instruccion = $"delete from tb_alumnos where carnet = '{carnet}'";
            return comm.EjecutarSQLDirecto(instruccion);
        }


    }
}

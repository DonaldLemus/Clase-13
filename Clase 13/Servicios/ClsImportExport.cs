using Clase_13.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13.Servicios
{
    public class ClsImportExport
    {
        private ClsConexion cone;

        public ClsImportExport()
        {
            cone = new ClsConexion();
        }

        public string importar(String archivo)
        {
            string texto = "";
            try
            {
                texto = System.IO.File.ReadAllText(archivo);
                return $"Procesados: {cone.EjecutarSQLDirecto(texto)}";

            } catch (Exception ex)
            {
                return $"Hubo un error: {ex.Message}";
            }

        }

        public string exportar(string instruccion, string archivoDestino)
        {
            string textosalida = " ";
            DataTable respueta = cone.consultaTablaDirecta(instruccion);

            foreach (DataRow dr in respueta.Rows)
            {
                textosalida += $"{dr["idAlumno"]};{dr["carnet"]};{dr["nombre"]};{dr["correo"]};{dr["correo"]};{dr["clase"]};{dr["seccion"]};{dr["parcial1"]};{dr["parcial2"]};{dr["parcial3"]}\n";
            }

            if (!string.IsNullOrEmpty(textosalida))
            {
                try
                {
                    File.WriteAllText(archivoDestino, textosalida);
                    return $"Procesado: {archivoDestino}";



                } catch (Exception ex)
                {
                    return $"Hay un problema_ {ex.Message}";
                }
            }
            return "No se encontró nada";
        }

    }
}


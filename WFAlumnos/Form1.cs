using Clase_13.Entidades;
using Clase_13.Servicios;
using System.Data;

namespace WFAlumnos
{
    public partial class Form1 : Form
    {
        ServicioAlumno srvAlumno = new();
        MdAlumno oAlumno = new();


        public Form1()
        {
            InitializeComponent();
        }

        void cargarGrid()
        {
            var resultado = srvAlumno.ConsultaSQL("select * from tb_alumnos");
            dataGridAlumno.DataSource = resultado;
        }
        


        void MapeoDatasFormulario(MdAlumno _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBoxParcial1.Text = Convert.ToString(_alumnos.parcial1);
            textBoxParcial2.Text = Convert.ToString(_alumnos.parcial2);
            textBoxParcial3.Text = Convert.ToString(_alumnos.parcial3);
        }

        void buscarAlumno(string _carnet)
        {
            oAlumno = null;
            oAlumno = srvAlumno.ObtenerAlumno(_carnet);

            if(oAlumno == null)
            {
                MessageBox.Show("Este alumno no existe");
                LimpiarFormulario();
            }
            else
            {
                MapeoDatasFormulario(oAlumno);
            }
        }

        void LimpiarFormulario()
        {
            oAlumno = new();
            MapeoDatasFormulario(oAlumno);
        }

        private MdAlumno DatosFormulario()
        {
            MdAlumno _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo = textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = Convert.ToInt32(textBoxParcial1.Text);
            _alumnos.parcial2 = Convert.ToInt32(textBoxParcial2.Text);
            _alumnos.parcial3 = Convert.ToInt32(textBoxParcial3.Text);
            return _alumnos;
        }

        public bool Parciales()
        {
            oAlumno = DatosFormulario();
            bool _parciales = false;

            int parcial1,parcial2, parcial3;
            parcial1 = Convert.ToInt32(oAlumno.parcial1);
            parcial2 = Convert.ToInt32(oAlumno.parcial2);
            parcial3 = Convert.ToInt32(oAlumno.parcial3);

            if (parcial1 <= 20 && parcial2 <= 20 && parcial3 <= 35)
            {
                _parciales = true;
            }
            else if(parcial1 > 20 && parcial2 > 20 && parcial3 > 35)
            {
                _parciales = false;
            }

            return _parciales;

        }

        public int Duplicado()
        {
            oAlumno = DatosFormulario();
            int acceso = -1;

            string carnet = oAlumno.carnet;
            DataTable resp = srvAlumno.ConsultaSQL($"select * from tb_alumnos where carnet = '{carnet}'");
            int repetido = resp.Rows.Count;

            if(repetido > 0)
            {
                acceso = 0;
            }
            else
            {
                acceso = 1;
            }
            return acceso;
        }

        public bool NombreVacio()
        {
            string nombre = textBoxNombre.Text;
            bool acceso = false;

            if (!string.IsNullOrEmpty(nombre))
            {
                acceso = true;
            }
            else
            {
                acceso = false;
            }

            return acceso;
        }

        public void Comprobacion()
        {
            Duplicado();
            NombreVacio();
            Parciales();

            if(Duplicado() != 0)
            {
                if (NombreVacio() == true)
                {
                    if (Parciales() == true)
                    {
                        oAlumno = DatosFormulario();
                        int respuesta = srvAlumno.crearAlumno(oAlumno);

                        if (respuesta > 0)
                        {
                            MessageBox.Show("Se grabó con Exito");
                            cargarGrid();
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo grabar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La nota ingresada superó el limite permitido");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre no puede estar vacío");
                }
            }
            else
            {
                MessageBox.Show("Este carnet ya existe");
            }
        }

        public void Actualizar()
        {
            NombreVacio();
            Parciales();
            if (NombreVacio() == true)
            {
                if (Parciales() == true)
                {
                    oAlumno = DatosFormulario();
                    int respuesta = srvAlumno.actualizarAlumno(oAlumno);

                    if (respuesta > 0)
                    {
                        MessageBox.Show("Se grabó con Exito");
                        LimpiarFormulario();
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo grabar");
                    }
                }
                else
                {
                    MessageBox.Show("La nota ingresada superó el limite permitido");
                }
            }
            else
            {
                MessageBox.Show("El nombre no puede estar vacío");
            }
        }

        public void Eliminar()
        {
            oAlumno = DatosFormulario();

            if (!string.IsNullOrEmpty(oAlumno.carnet))
            {
                if (MessageBox.Show("¿Seguro de eliminar este alumno?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int respuesta = srvAlumno.eliminarAlumno(oAlumno.carnet);
                    if (respuesta > 0)
                    {
                        MessageBox.Show("Se elimino el alumno");
                        LimpiarFormulario();
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el alumno porque no existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado un carnet");
            }
          
           
        }

        void importar()
        {
            string archivo = @"C:\Users\ASUS\Downloads\alumnos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        void exportar()
        {
            string archivo = @"C:\Users\ASUS\Downloads\UMG\03 Tercer Semestre\Programaciónn 1\Proyecto.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos", archivo));
        }
        private void buttonConexion_Click(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscarAlumno(carnet);
        }
         
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            Comprobacion();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            importar();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            exportar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

    }
}
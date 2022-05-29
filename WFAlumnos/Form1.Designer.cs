namespace WFAlumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVerTabla = new System.Windows.Forms.Button();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.comboBoxClase = new System.Windows.Forms.ComboBox();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCrearAlumno = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.labelParcial1 = new System.Windows.Forms.Label();
            this.textBoxParcial1 = new System.Windows.Forms.TextBox();
            this.labelParcial2 = new System.Windows.Forms.Label();
            this.textBoxParcial2 = new System.Windows.Forms.TextBox();
            this.labelParcial3 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxParcial3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVerTabla
            // 
            this.buttonVerTabla.Location = new System.Drawing.Point(558, 501);
            this.buttonVerTabla.Name = "buttonVerTabla";
            this.buttonVerTabla.Size = new System.Drawing.Size(146, 40);
            this.buttonVerTabla.TabIndex = 0;
            this.buttonVerTabla.Text = "Ver Tabla de Alumnos";
            this.buttonVerTabla.UseVisualStyleBackColor = true;
            this.buttonVerTabla.Click += new System.EventHandler(this.buttonConexion_Click);
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridAlumno.Location = new System.Drawing.Point(762, 0);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.RowTemplate.Height = 25;
            this.dataGridAlumno.Size = new System.Drawing.Size(924, 652);
            this.dataGridAlumno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clase";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(116, 61);
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(217, 23);
            this.textBoxCarnet.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(116, 105);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(297, 23);
            this.textBoxNombre.TabIndex = 9;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(116, 157);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(297, 23);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(116, 200);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSeccion.TabIndex = 11;
            // 
            // comboBoxClase
            // 
            this.comboBoxClase.FormattingEnabled = true;
            this.comboBoxClase.Items.AddRange(new object[] {
            "Programacion I",
            "Programacion II",
            "Programacion III",
            "Electronica",
            "Matematica"});
            this.comboBoxClase.Location = new System.Drawing.Point(116, 245);
            this.comboBoxClase.Name = "comboBoxClase";
            this.comboBoxClase.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClase.TabIndex = 12;
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(28, 407);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(119, 40);
            this.buttonConsulta.TabIndex = 13;
            this.buttonConsulta.Text = "Consultar";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(406, 501);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(132, 40);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar Formulario";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCrearAlumno
            // 
            this.buttonCrearAlumno.Location = new System.Drawing.Point(182, 407);
            this.buttonCrearAlumno.Name = "buttonCrearAlumno";
            this.buttonCrearAlumno.Size = new System.Drawing.Size(122, 40);
            this.buttonCrearAlumno.TabIndex = 15;
            this.buttonCrearAlumno.Text = "Crear Alumno";
            this.buttonCrearAlumno.UseVisualStyleBackColor = true;
            this.buttonCrearAlumno.Click += new System.EventHandler(this.buttonCrearAlumno_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(340, 407);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(119, 40);
            this.buttonActualizar.TabIndex = 16;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Location = new System.Drawing.Point(25, 501);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(122, 40);
            this.buttonImportar.TabIndex = 17;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(166, 501);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(122, 40);
            this.buttonExportar.TabIndex = 18;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // labelParcial1
            // 
            this.labelParcial1.AutoSize = true;
            this.labelParcial1.Location = new System.Drawing.Point(68, 309);
            this.labelParcial1.Name = "labelParcial1";
            this.labelParcial1.Size = new System.Drawing.Size(51, 15);
            this.labelParcial1.TabIndex = 19;
            this.labelParcial1.Text = "Parcial 1";
            // 
            // textBoxParcial1
            // 
            this.textBoxParcial1.Location = new System.Drawing.Point(125, 306);
            this.textBoxParcial1.Name = "textBoxParcial1";
            this.textBoxParcial1.Size = new System.Drawing.Size(44, 23);
            this.textBoxParcial1.TabIndex = 20;
            // 
            // labelParcial2
            // 
            this.labelParcial2.AutoSize = true;
            this.labelParcial2.Location = new System.Drawing.Point(203, 309);
            this.labelParcial2.Name = "labelParcial2";
            this.labelParcial2.Size = new System.Drawing.Size(51, 15);
            this.labelParcial2.TabIndex = 21;
            this.labelParcial2.Text = "Parcial 2";
            // 
            // textBoxParcial2
            // 
            this.textBoxParcial2.Location = new System.Drawing.Point(260, 306);
            this.textBoxParcial2.Name = "textBoxParcial2";
            this.textBoxParcial2.Size = new System.Drawing.Size(44, 23);
            this.textBoxParcial2.TabIndex = 22;
            // 
            // labelParcial3
            // 
            this.labelParcial3.AutoSize = true;
            this.labelParcial3.Location = new System.Drawing.Point(330, 309);
            this.labelParcial3.Name = "labelParcial3";
            this.labelParcial3.Size = new System.Drawing.Size(51, 15);
            this.labelParcial3.TabIndex = 24;
            this.labelParcial3.Text = "Parcial 3";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(484, 407);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(119, 40);
            this.buttonEliminar.TabIndex = 27;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxParcial3
            // 
            this.textBoxParcial3.Location = new System.Drawing.Point(384, 306);
            this.textBoxParcial3.Name = "textBoxParcial3";
            this.textBoxParcial3.Size = new System.Drawing.Size(44, 23);
            this.textBoxParcial3.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 652);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelParcial3);
            this.Controls.Add(this.textBoxParcial3);
            this.Controls.Add(this.textBoxParcial2);
            this.Controls.Add(this.labelParcial2);
            this.Controls.Add(this.textBoxParcial1);
            this.Controls.Add(this.labelParcial1);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrearAlumno);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.comboBoxClase);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridAlumno);
            this.Controls.Add(this.buttonVerTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonVerTabla;
        private DataGridView dataGridAlumno;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxCarnet;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private ComboBox comboBoxSeccion;
        private ComboBox comboBoxClase;
        private Button buttonConsulta;
        private Button buttonLimpiar;
        private Button buttonCrearAlumno;
        private Button buttonActualizar;
        private Button buttonImportar;
        private Button buttonExportar;
        private Label labelParcial1;
        private TextBox textBoxParcial1;
        private Label labelParcial2;
        private TextBox textBoxParcial2;
        private Label labelParcial3;
        private Button buttonEliminar;
        private TextBox textBoxParcial3;
    }
}
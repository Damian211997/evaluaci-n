namespace evaluacion
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
            Gestion = new TabControl();
            GestionUsuarios = new TabPage();
            btnGuardar = new Button();
            dataGridView3 = new DataGridView();
            IdUsuarios = new DataGridViewTextBoxColumn();
            ColumnNombreUsuario = new DataGridViewTextBoxColumn();
            ColumnGmail = new DataGridViewTextBoxColumn();
            ColumnEditarUsuario = new DataGridViewButtonColumn();
            ColumnEliminarUsuario = new DataGridViewButtonColumn();
            lbGmail = new Label();
            tbGmail = new TextBox();
            tbUsuario = new TextBox();
            lbNombreUsuario = new Label();
            tabProyectos = new TabPage();
            estadoProyecto = new GroupBox();
            rbFinalizado = new RadioButton();
            rbProceso = new RadioButton();
            buttonGuardar = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            ColumnHrsTrabajadas = new DataGridViewTextBoxColumn();
            ColumnHrsTotales = new DataGridViewTextBoxColumn();
            ColumnFechaCreacion = new DataGridViewTextBoxColumn();
            ButtonEditar = new DataGridViewButtonColumn();
            ButtonEliminar = new DataGridViewButtonColumn();
            label2 = new Label();
            numericHorasTotales = new NumericUpDown();
            Descripcion = new Label();
            textBoxDescripcion = new TextBox();
            textName = new TextBox();
            Nombre = new Label();
            tabTareas = new TabPage();
            lbProyecto = new Label();
            comboBoxProyecto = new ComboBox();
            comboBoxEmpleado = new ComboBox();
            lbEmpleado = new Label();
            gbEstadoTabla = new GroupBox();
            rbFinalizadoTabla = new RadioButton();
            rbProcesoTabla = new RadioButton();
            gbArea = new GroupBox();
            rbRedes = new RadioButton();
            rbHardware = new RadioButton();
            dataGridView2 = new DataGridView();
            IDTareas = new DataGridViewTextBoxColumn();
            ClumnFechaInicio = new DataGridViewTextBoxColumn();
            ColumnEstado2 = new DataGridViewTextBoxColumn();
            ColumnHoras = new DataGridViewTextBoxColumn();
            ColumnArea = new DataGridViewTextBoxColumn();
            ColumnProyecto = new DataGridViewTextBoxColumn();
            ColumnEmpleado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Agregar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            buttonCancelar2 = new Button();
            buttonGuardar2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            dateInicio = new DateTimePicker();
            FEinicio = new Label();
            Gestion.SuspendLayout();
            GestionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabProyectos.SuspendLayout();
            estadoProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHorasTotales).BeginInit();
            tabTareas.SuspendLayout();
            gbEstadoTabla.SuspendLayout();
            gbArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Gestion
            // 
            Gestion.Controls.Add(GestionUsuarios);
            Gestion.Controls.Add(tabProyectos);
            Gestion.Controls.Add(tabTareas);
            Gestion.Location = new Point(12, 0);
            Gestion.Name = "Gestion";
            Gestion.SelectedIndex = 0;
            Gestion.Size = new Size(729, 509);
            Gestion.TabIndex = 2;
            // 
            // GestionUsuarios
            // 
            GestionUsuarios.Controls.Add(btnGuardar);
            GestionUsuarios.Controls.Add(dataGridView3);
            GestionUsuarios.Controls.Add(lbGmail);
            GestionUsuarios.Controls.Add(tbGmail);
            GestionUsuarios.Controls.Add(tbUsuario);
            GestionUsuarios.Controls.Add(lbNombreUsuario);
            GestionUsuarios.Location = new Point(4, 29);
            GestionUsuarios.Name = "GestionUsuarios";
            GestionUsuarios.Padding = new Padding(3);
            GestionUsuarios.Size = new Size(721, 476);
            GestionUsuarios.TabIndex = 2;
            GestionUsuarios.Text = "Usuarios";
            GestionUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(604, 98);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { IdUsuarios, ColumnNombreUsuario, ColumnGmail, ColumnEditarUsuario, ColumnEliminarUsuario });
            dataGridView3.Location = new Point(19, 180);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(679, 115);
            dataGridView3.TabIndex = 4;
            // 
            // IdUsuarios
            // 
            IdUsuarios.HeaderText = "ID";
            IdUsuarios.MinimumWidth = 6;
            IdUsuarios.Name = "IdUsuarios";
            IdUsuarios.Width = 125;
            // 
            // ColumnNombreUsuario
            // 
            ColumnNombreUsuario.HeaderText = "Nombre";
            ColumnNombreUsuario.MinimumWidth = 6;
            ColumnNombreUsuario.Name = "ColumnNombreUsuario";
            ColumnNombreUsuario.Width = 125;
            // 
            // ColumnGmail
            // 
            ColumnGmail.HeaderText = "Gmail";
            ColumnGmail.MinimumWidth = 6;
            ColumnGmail.Name = "ColumnGmail";
            ColumnGmail.Width = 125;
            // 
            // ColumnEditarUsuario
            // 
            ColumnEditarUsuario.HeaderText = "Editar";
            ColumnEditarUsuario.MinimumWidth = 6;
            ColumnEditarUsuario.Name = "ColumnEditarUsuario";
            ColumnEditarUsuario.Width = 125;
            // 
            // ColumnEliminarUsuario
            // 
            ColumnEliminarUsuario.HeaderText = "Eliminar";
            ColumnEliminarUsuario.MinimumWidth = 6;
            ColumnEliminarUsuario.Name = "ColumnEliminarUsuario";
            ColumnEliminarUsuario.Width = 125;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Location = new Point(19, 107);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(48, 20);
            lbGmail.TabIndex = 3;
            lbGmail.Text = "Gmail";
            // 
            // tbGmail
            // 
            tbGmail.Location = new Point(89, 100);
            tbGmail.Name = "tbGmail";
            tbGmail.Size = new Size(313, 27);
            tbGmail.TabIndex = 2;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(89, 43);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(313, 27);
            tbUsuario.TabIndex = 1;
            // 
            // lbNombreUsuario
            // 
            lbNombreUsuario.AutoSize = true;
            lbNombreUsuario.Location = new Point(19, 46);
            lbNombreUsuario.Name = "lbNombreUsuario";
            lbNombreUsuario.Size = new Size(64, 20);
            lbNombreUsuario.TabIndex = 0;
            lbNombreUsuario.Text = "Nombre";
            // 
            // tabProyectos
            // 
            tabProyectos.Controls.Add(estadoProyecto);
            tabProyectos.Controls.Add(buttonGuardar);
            tabProyectos.Controls.Add(dataGridView1);
            tabProyectos.Controls.Add(label2);
            tabProyectos.Controls.Add(numericHorasTotales);
            tabProyectos.Controls.Add(Descripcion);
            tabProyectos.Controls.Add(textBoxDescripcion);
            tabProyectos.Controls.Add(textName);
            tabProyectos.Controls.Add(Nombre);
            tabProyectos.Location = new Point(4, 29);
            tabProyectos.Name = "tabProyectos";
            tabProyectos.Padding = new Padding(3);
            tabProyectos.Size = new Size(1026, 476);
            tabProyectos.TabIndex = 0;
            tabProyectos.Text = "Proyectos";
            tabProyectos.UseVisualStyleBackColor = true;
            // 
            // estadoProyecto
            // 
            estadoProyecto.Controls.Add(rbFinalizado);
            estadoProyecto.Controls.Add(rbProceso);
            estadoProyecto.Location = new Point(689, 38);
            estadoProyecto.Name = "estadoProyecto";
            estadoProyecto.Size = new Size(269, 100);
            estadoProyecto.TabIndex = 15;
            estadoProyecto.TabStop = false;
            estadoProyecto.Text = "Estado";
            // 
            // rbFinalizado
            // 
            rbFinalizado.AutoSize = true;
            rbFinalizado.Location = new Point(155, 45);
            rbFinalizado.Name = "rbFinalizado";
            rbFinalizado.Size = new Size(98, 24);
            rbFinalizado.TabIndex = 1;
            rbFinalizado.TabStop = true;
            rbFinalizado.Text = "Finalizado";
            rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbProceso
            // 
            rbProceso.AutoSize = true;
            rbProceso.Location = new Point(22, 45);
            rbProceso.Name = "rbProceso";
            rbProceso.Size = new Size(102, 24);
            rbProceso.TabIndex = 0;
            rbProceso.TabStop = true;
            rbProceso.Text = "En Proceso";
            rbProceso.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(864, 241);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 13;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ColumnNombre, ColumnDescripcion, ColumnEstado, ColumnHrsTrabajadas, ColumnHrsTotales, ColumnFechaCreacion, ButtonEditar, ButtonEliminar });
            dataGridView1.Location = new Point(8, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(950, 182);
            dataGridView1.TabIndex = 12;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.MinimumWidth = 6;
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.Width = 125;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.HeaderText = "Descripcion";
            ColumnDescripcion.MinimumWidth = 6;
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.Width = 125;
            // 
            // ColumnEstado
            // 
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.MinimumWidth = 6;
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.Resizable = DataGridViewTriState.True;
            ColumnEstado.Width = 125;
            // 
            // ColumnHrsTrabajadas
            // 
            ColumnHrsTrabajadas.HeaderText = "Horas Trabajadas";
            ColumnHrsTrabajadas.MinimumWidth = 6;
            ColumnHrsTrabajadas.Name = "ColumnHrsTrabajadas";
            ColumnHrsTrabajadas.Width = 125;
            // 
            // ColumnHrsTotales
            // 
            ColumnHrsTotales.HeaderText = "Horas Totales ";
            ColumnHrsTotales.MinimumWidth = 6;
            ColumnHrsTotales.Name = "ColumnHrsTotales";
            ColumnHrsTotales.Width = 125;
            // 
            // ColumnFechaCreacion
            // 
            ColumnFechaCreacion.HeaderText = "Fecha de Creacion";
            ColumnFechaCreacion.MinimumWidth = 6;
            ColumnFechaCreacion.Name = "ColumnFechaCreacion";
            ColumnFechaCreacion.Width = 125;
            // 
            // ButtonEditar
            // 
            ButtonEditar.HeaderText = "Editar";
            ButtonEditar.MinimumWidth = 6;
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Width = 125;
            // 
            // ButtonEliminar
            // 
            ButtonEliminar.HeaderText = "Eliminar";
            ButtonEliminar.MinimumWidth = 6;
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 180);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 11;
            label2.Text = "Horas Totales";
            // 
            // numericHorasTotales
            // 
            numericHorasTotales.Location = new Point(808, 180);
            numericHorasTotales.Name = "numericHorasTotales";
            numericHorasTotales.Size = new Size(150, 27);
            numericHorasTotales.TabIndex = 10;
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(8, 97);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(87, 20);
            Descripcion.TabIndex = 3;
            Descripcion.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(101, 97);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(454, 103);
            textBoxDescripcion.TabIndex = 2;
            // 
            // textName
            // 
            textName.Location = new Point(101, 38);
            textName.Name = "textName";
            textName.Size = new Size(454, 27);
            textName.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(31, 38);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // tabTareas
            // 
            tabTareas.Controls.Add(lbProyecto);
            tabTareas.Controls.Add(comboBoxProyecto);
            tabTareas.Controls.Add(comboBoxEmpleado);
            tabTareas.Controls.Add(lbEmpleado);
            tabTareas.Controls.Add(gbEstadoTabla);
            tabTareas.Controls.Add(gbArea);
            tabTareas.Controls.Add(dataGridView2);
            tabTareas.Controls.Add(buttonCancelar2);
            tabTareas.Controls.Add(buttonGuardar2);
            tabTareas.Controls.Add(numericUpDown1);
            tabTareas.Controls.Add(label3);
            tabTareas.Controls.Add(dateInicio);
            tabTareas.Controls.Add(FEinicio);
            tabTareas.Location = new Point(4, 29);
            tabTareas.Name = "tabTareas";
            tabTareas.Padding = new Padding(3);
            tabTareas.Size = new Size(1026, 476);
            tabTareas.TabIndex = 1;
            tabTareas.Text = "Tareas";
            tabTareas.UseVisualStyleBackColor = true;
            // 
            // lbProyecto
            // 
            lbProyecto.AutoSize = true;
            lbProyecto.Location = new Point(18, 80);
            lbProyecto.Name = "lbProyecto";
            lbProyecto.Size = new Size(73, 20);
            lbProyecto.TabIndex = 20;
            lbProyecto.Text = "Proyectos";
            // 
            // comboBoxProyecto
            // 
            comboBoxProyecto.FormattingEnabled = true;
            comboBoxProyecto.Location = new Point(107, 77);
            comboBoxProyecto.Name = "comboBoxProyecto";
            comboBoxProyecto.Size = new Size(423, 28);
            comboBoxProyecto.TabIndex = 19;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(107, 21);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(423, 28);
            comboBoxEmpleado.TabIndex = 18;
            // 
            // lbEmpleado
            // 
            lbEmpleado.AutoSize = true;
            lbEmpleado.Location = new Point(18, 24);
            lbEmpleado.Name = "lbEmpleado";
            lbEmpleado.Size = new Size(83, 20);
            lbEmpleado.TabIndex = 17;
            lbEmpleado.Text = "Empleados";
            // 
            // gbEstadoTabla
            // 
            gbEstadoTabla.Controls.Add(rbFinalizadoTabla);
            gbEstadoTabla.Controls.Add(rbProcesoTabla);
            gbEstadoTabla.Location = new Point(24, 140);
            gbEstadoTabla.Name = "gbEstadoTabla";
            gbEstadoTabla.Size = new Size(250, 98);
            gbEstadoTabla.TabIndex = 16;
            gbEstadoTabla.TabStop = false;
            gbEstadoTabla.Text = "Estado";
            // 
            // rbFinalizadoTabla
            // 
            rbFinalizadoTabla.AutoSize = true;
            rbFinalizadoTabla.Location = new Point(146, 38);
            rbFinalizadoTabla.Name = "rbFinalizadoTabla";
            rbFinalizadoTabla.Size = new Size(98, 24);
            rbFinalizadoTabla.TabIndex = 1;
            rbFinalizadoTabla.TabStop = true;
            rbFinalizadoTabla.Text = "Finalizado";
            rbFinalizadoTabla.UseVisualStyleBackColor = true;
            // 
            // rbProcesoTabla
            // 
            rbProcesoTabla.AutoSize = true;
            rbProcesoTabla.Location = new Point(12, 38);
            rbProcesoTabla.Name = "rbProcesoTabla";
            rbProcesoTabla.Size = new Size(102, 24);
            rbProcesoTabla.TabIndex = 0;
            rbProcesoTabla.TabStop = true;
            rbProcesoTabla.Text = "En Proceso";
            rbProcesoTabla.UseVisualStyleBackColor = true;
            // 
            // gbArea
            // 
            gbArea.Controls.Add(rbRedes);
            gbArea.Controls.Add(rbHardware);
            gbArea.Location = new Point(280, 140);
            gbArea.Name = "gbArea";
            gbArea.Size = new Size(250, 98);
            gbArea.TabIndex = 15;
            gbArea.TabStop = false;
            gbArea.Text = "Area";
            // 
            // rbRedes
            // 
            rbRedes.AutoSize = true;
            rbRedes.Location = new Point(156, 40);
            rbRedes.Name = "rbRedes";
            rbRedes.Size = new Size(70, 24);
            rbRedes.TabIndex = 1;
            rbRedes.TabStop = true;
            rbRedes.Text = "Redes";
            rbRedes.UseVisualStyleBackColor = true;
            // 
            // rbHardware
            // 
            rbHardware.AutoSize = true;
            rbHardware.Location = new Point(13, 40);
            rbHardware.Name = "rbHardware";
            rbHardware.Size = new Size(95, 24);
            rbHardware.TabIndex = 0;
            rbHardware.TabStop = true;
            rbHardware.Text = "Hardware";
            rbHardware.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDTareas, ClumnFechaInicio, ColumnEstado2, ColumnHoras, ColumnArea, ColumnProyecto, ColumnEmpleado, Editar, Agregar, Eliminar });
            dataGridView2.Location = new Point(24, 254);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(963, 188);
            dataGridView2.TabIndex = 14;
            // 
            // IDTareas
            // 
            IDTareas.HeaderText = "ID";
            IDTareas.MinimumWidth = 6;
            IDTareas.Name = "IDTareas";
            IDTareas.Width = 125;
            // 
            // ClumnFechaInicio
            // 
            ClumnFechaInicio.HeaderText = "Fecha de Inicio";
            ClumnFechaInicio.MinimumWidth = 6;
            ClumnFechaInicio.Name = "ClumnFechaInicio";
            ClumnFechaInicio.Width = 125;
            // 
            // ColumnEstado2
            // 
            ColumnEstado2.HeaderText = "Estado";
            ColumnEstado2.MinimumWidth = 6;
            ColumnEstado2.Name = "ColumnEstado2";
            ColumnEstado2.Width = 125;
            // 
            // ColumnHoras
            // 
            ColumnHoras.HeaderText = "Horas";
            ColumnHoras.MinimumWidth = 6;
            ColumnHoras.Name = "ColumnHoras";
            ColumnHoras.Width = 125;
            // 
            // ColumnArea
            // 
            ColumnArea.HeaderText = "Area";
            ColumnArea.MinimumWidth = 6;
            ColumnArea.Name = "ColumnArea";
            ColumnArea.Width = 125;
            // 
            // ColumnProyecto
            // 
            ColumnProyecto.HeaderText = "Proyecto";
            ColumnProyecto.MinimumWidth = 6;
            ColumnProyecto.Name = "ColumnProyecto";
            ColumnProyecto.Width = 125;
            // 
            // ColumnEmpleado
            // 
            ColumnEmpleado.HeaderText = "Empleado Asignado";
            ColumnEmpleado.MinimumWidth = 6;
            ColumnEmpleado.Name = "ColumnEmpleado";
            ColumnEmpleado.Width = 125;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Width = 125;
            // 
            // Agregar
            // 
            Agregar.HeaderText = "Agregar";
            Agregar.MinimumWidth = 6;
            Agregar.Name = "Agregar";
            Agregar.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 125;
            // 
            // buttonCancelar2
            // 
            buttonCancelar2.Location = new Point(893, 219);
            buttonCancelar2.Name = "buttonCancelar2";
            buttonCancelar2.Size = new Size(94, 29);
            buttonCancelar2.TabIndex = 13;
            buttonCancelar2.Text = "Cancelar";
            buttonCancelar2.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar2
            // 
            buttonGuardar2.Location = new Point(893, 175);
            buttonGuardar2.Name = "buttonGuardar2";
            buttonGuardar2.Size = new Size(94, 29);
            buttonGuardar2.TabIndex = 12;
            buttonGuardar2.Text = "Guardar";
            buttonGuardar2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(812, 85);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(175, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(758, 87);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "Horas";
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(689, 24);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(298, 27);
            dateInicio.TabIndex = 2;
            // 
            // FEinicio
            // 
            FEinicio.AutoSize = true;
            FEinicio.Location = new Point(575, 24);
            FEinicio.Name = "FEinicio";
            FEinicio.Size = new Size(108, 20);
            FEinicio.TabIndex = 1;
            FEinicio.Text = "Fecha de Inicio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 596);
            Controls.Add(Gestion);
            Name = "Form1";
            Text = "Gestiones";
            Load += Form1_Load;
            Gestion.ResumeLayout(false);
            GestionUsuarios.ResumeLayout(false);
            GestionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabProyectos.ResumeLayout(false);
            tabProyectos.PerformLayout();
            estadoProyecto.ResumeLayout(false);
            estadoProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHorasTotales).EndInit();
            tabTareas.ResumeLayout(false);
            tabTareas.PerformLayout();
            gbEstadoTabla.ResumeLayout(false);
            gbEstadoTabla.PerformLayout();
            gbArea.ResumeLayout(false);
            gbArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Gestion;
        private TabPage tabProyectos;
        private TabPage tabTareas;
        private TextBox textBoxDescripcion;
        private Label Nombre;
        private Label Descripcion;
        private DateTimePicker Date1;
        private NumericUpDown numericHorasTotales;
        private Label label2;
        private DataGridView dataGridView1;
        private Button buttonGuardar;
        private TextBox textName;
        private TextBox textName2;
        private Label FEinicio;
        private DateTimePicker dateInicio;
        private Label label3;
        private Button buttonGuardar2;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView2;
        private Button buttonCancelar2;
        private DataGridViewTextBoxColumn IDTareas;
        private DataGridViewTextBoxColumn ClumnFechaInicio;
        private DataGridViewTextBoxColumn ColumnEstado2;
        private DataGridViewTextBoxColumn ColumnHoras;
        private DataGridViewTextBoxColumn ColumnArea;
        private DataGridViewTextBoxColumn ColumnProyecto;
        private DataGridViewTextBoxColumn ColumnEmpleado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Agregar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridViewTextBoxColumn ColumnHrsTrabajadas;
        private DataGridViewTextBoxColumn ColumnHrsTotales;
        private DataGridViewTextBoxColumn ColumnFechaCreacion;
        private DataGridViewButtonColumn ButtonEditar;
        private DataGridViewButtonColumn ButtonEliminar;
        private GroupBox estadoProyecto;
        private RadioButton rbFinalizado;
        private RadioButton rbProceso;
        private GroupBox gbArea;
        private RadioButton rbRedes;
        private RadioButton rbHardware;
        private GroupBox gbEstadoTabla;
        private RadioButton rbFinalizadoTabla;
        private RadioButton rbProcesoTabla;
        private TabPage GestionUsuarios;
        private DataGridView dataGridView3;
        private Label lbGmail;
        private TextBox tbGmail;
        private TextBox tbUsuario;
        private Label lbNombreUsuario;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn IdUsuarios;
        private DataGridViewTextBoxColumn ColumnNombreUsuario;
        private DataGridViewTextBoxColumn ColumnGmail;
        private DataGridViewButtonColumn ColumnEditarUsuario;
        private DataGridViewButtonColumn ColumnEliminarUsuario;
        private ComboBox comboBoxEmpleado;
        private Label lbEmpleado;
        private Label lbProyecto;
        private ComboBox comboBoxProyecto;

        public object DateCreacion { get; private set; }
    }
}

namespace evaluacion
{
    public partial class Form1 : Form
    {
        private bool isEditing = false; // VARIABLE PARA DIFERENCIAR EL MODO EDICION DEL MODO GUARDAR
        private int currentEditId = -1; // VARIABLE PARA ALMACENAR EL ID DEL PROYECTO EN EDICION
        private bool isEditingUser = false;
        private int currentEditUserId = -1;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeUserDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView3.CellClick += dataGridView3_CellClick;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textName.Text;
            string descripcion = textBoxDescripcion.Text;
            int horasTotales = (int)numericHorasTotales.Value;

            if (isEditing)
            {
                if (currentEditId == -1)
                {
                    MessageBox.Show("NO HAY PROYECTO SELECCIONADO PARA EDITAR.");
                    return;
                }

                // MODO EDICION "ACTUALIZAR"
                ActualizarProyecto(currentEditId, nombre, descripcion);
            }
            else
            {
                // MODO CREACION "GUARDAR"
                CrearProyecto(nombre, descripcion, horasTotales);
            }
        }

        private void CrearProyecto(string nombre, string descripcion, int horasTotales)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion) || horasTotales <= 0)
            {
                MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACIOS Y LAS HORAS TOTALES DEBEN SER MAYORES A 0.");
                return;
            }

            //GENERAR UN ID INCREMENTABLE
            int nuevoId = dataGridView1.Rows.Count;

            //INICIAR EL ESTADO EN PENDIENTE
            string estadoInicial = "Pendiente";

            //MOSTRAR FECHA ACTUAL
            DateTime fechaCreacion = DateTime.Now;

            //AÑADIR UN NUEVO PROYECTO A LA TABLA
            dataGridView1.Rows.Add(nuevoId, nombre, descripcion, estadoInicial, 0, horasTotales, fechaCreacion);
        }

        private void EliminarProyecto(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["ID"].Value == id)
                {
                    var confirmResult = MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR ESTE PROYECTO?", "CONFIRMAR ELIMINACION", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Remove(row);
                        MessageBox.Show("PROYECTO ELIMINADO CORRECTAMENTE.");
                    }
                    return;
                }
            }
        }

        //INICIALIZAR TODAS LAS COLUMNAS DE LA TABLA
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ColumnNombre", "Nombre");
            dataGridView1.Columns.Add("ColumnDescripcion", "Descripción");
            dataGridView1.Columns.Add("ColumnEstado", "Estado");
            dataGridView1.Columns.Add("ColumnHrsTrabajadas", "Horas Trabajadas");
            dataGridView1.Columns.Add("ColumnHrsTotales", "Horas Totales");
            dataGridView1.Columns.Add("ColumnFechaCreacion", "Fecha Creación");

            ButtonEditar = new DataGridViewButtonColumn();
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.HeaderText = "Editar";
            ButtonEditar.Text = "Editar";
            ButtonEditar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(ButtonEditar);

            ButtonEliminar = new DataGridViewButtonColumn();
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.HeaderText = "Eliminar";
            ButtonEliminar.Text = "Eliminar";
            ButtonEliminar.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(ButtonEliminar);
        }

        //MANEJAR LOS BOTONES EDITAR Y ELIMINAR
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["ButtonEditar"].Index ||
                                     e.ColumnIndex == dataGridView1.Columns["ButtonEliminar"].Index))
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;

                if (e.ColumnIndex == dataGridView1.Columns["ButtonEditar"].Index)
                {
                    EditarProyecto(id);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["ButtonEliminar"].Index)
                {
                    EliminarProyecto(id);
                }
            }
        }

        private void EditarProyecto(int id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["ID"].Value == id)
                {
                    textName.Text = row.Cells["ColumnNombre"].Value.ToString();
                    textBoxDescripcion.Text = row.Cells["ColumnDescripcion"].Value.ToString();
                    numericHorasTotales.Value = Convert.ToInt32(row.Cells["ColumnHrsTotales"].Value);

                    buttonGuardar.Text = "Actualizar";
                    isEditing = true; // CAMBIAR EL ESTADO DEL BOTON A EDICION
                    currentEditId = id; // ESTABLECER LA ID DEL PROYECTO EN EDICION

                    return;
                }
            }
        }

        private void ActualizarProyecto(int id, string nuevoNombre, string nuevaDescripcion)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["ID"].Value == id)
                {
                    row.Cells["ColumnNombre"].Value = nuevoNombre;
                    row.Cells["ColumnDescripcion"].Value = nuevaDescripcion;
                    MessageBox.Show("PROYECTO ACTUALIZADO CORRECTAMENTE.");

                    //VOLVER AL BOTON "GUARDAR"
                    buttonGuardar.Text = "Guardar";
                    isEditing = false; // CAMBIAR EL ESTADO DEL BOTON A CREACION
                    currentEditId = -1; // RESTABLECER LA ID DEL PROYECTO EN EDICION

                    return;
                }
            }
        }

        private void InitializeUserDataGridView()
        {
            
            dataGridView3.Columns.Clear();

            
            dataGridView3.Columns.Add("IdUsuarios", "ID");
            dataGridView3.Columns.Add("ColumnNombreUsuario", "Nombre Usuario");
            dataGridView3.Columns.Add("ColumnGmail", "Gmail");

            
            DataGridViewButtonColumn ButtonEditarUsuario = new DataGridViewButtonColumn();
            ButtonEditarUsuario.Name = "ColumnEditarUsuario";
            ButtonEditarUsuario.HeaderText = "Editar";
            ButtonEditarUsuario.Text = "Editar";
            ButtonEditarUsuario.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(ButtonEditarUsuario);

            DataGridViewButtonColumn ButtonEliminarUsuario = new DataGridViewButtonColumn();
            ButtonEliminarUsuario.Name = "ColumnEliminarUsuario";
            ButtonEliminarUsuario.HeaderText = "Eliminar";
            ButtonEliminarUsuario.Text = "Eliminar";
            ButtonEliminarUsuario.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(ButtonEliminarUsuario);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tbUsuario.Text;
            string gmail = tbGmail.Text;

            
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("ASEGURATE DE LLENAR TODOS LOS CAMPOS.");
                return;
            }

            if (isEditingUser)
            {
                
                ActualizarUsuario(currentEditUserId, nombreUsuario, gmail);
            }
            else
            {
                
                CrearUsuario(nombreUsuario, gmail);
            }
        }

        private void CrearUsuario(string nombreUsuario, string gmail)
        {
            
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(gmail))
            {
                MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACIOS.");
                return;
            }

            
            int nuevoId = dataGridView3.Rows.Count;

            
            dataGridView3.Rows.Add(nuevoId, nombreUsuario, gmail);
        }

        private void EditarUsuario(int id)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if ((int)row.Cells["IdUsuarios"].Value == id)
                {
                    
                    tbUsuario.Text = row.Cells["ColumnNombreUsuario"].Value.ToString();
                    tbGmail.Text = row.Cells["ColumnGmail"].Value.ToString();

                    
                    btnGuardar.Text = "Actualizar";
                    isEditingUser = true;
                    currentEditUserId = id;

                    return;
                }
            }
            MessageBox.Show("USUARIO NO ENCONTRADO.");
        }

        private void ActualizarUsuario(int id, string nuevoNombreUsuario, string nuevoGmail)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if ((int)row.Cells["IdUsuarios"].Value == id)
                {
                    row.Cells["ColumnNombreUsuario"].Value = nuevoNombreUsuario;
                    row.Cells["ColumnGmail"].Value = nuevoGmail;
                    MessageBox.Show("USUARIO ACTUALIZADO CORRECTAMENTE");

                    
                    btnGuardar.Text = "Guardar";
                    isEditingUser = false;
                    currentEditUserId = -1;
                    return;
                }
            }
            MessageBox.Show("USUARIO NO ENCONTRADO.");
        }

        private void EliminarUsuario(int id)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if ((int)row.Cells["IdUsuarios"].Value == id)
                {
                    var confirmResult = MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR ESTE USUARIO?", "CONFIRMAR ELIMINACION", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataGridView3.Rows.Remove(row);
                        MessageBox.Show("EL USUARIO HA SIDO ELIMINADO CORRECTAMENTE");
                    }
                    return;
                }
            }
            MessageBox.Show("USUARIO NO ENCONTRADO.");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView3.Columns["ColumnEditarUsuario"].Index ||
                                     e.ColumnIndex == dataGridView3.Columns["ColumnEliminarUsuario"].Index))
            {
                int id = (int)dataGridView3.Rows[e.RowIndex].Cells["IdUsuarios"].Value;

                if (e.ColumnIndex == dataGridView3.Columns["ColumnEditarUsuario"].Index)
                {
                    EditarUsuario(id);
                }
                else if (e.ColumnIndex == dataGridView3.Columns["ColumnEliminarUsuario"].Index)
                {
                    EliminarUsuario(id);
                }
            }
        }
    }
}

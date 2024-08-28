namespace evaluacion
{
    public partial class Form1 : Form
    {
        private bool isEditing = false; // VARIABLE PARA DIFERENCIAR EL MODO EDICION DEL MODO GUARDAR
        private int currentEditId = -1; // VARIABLE PARA ALMACENAR EL ID DEL PROYECTO EN EDICION

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += DataGridView1_CellClick;
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
        private void numericHorasTotales_ValueChanged(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridViewUsuarios()
        {
            dataGridView3.Columns.Clear();

            dataGridView3.Columns.Add("U_ID", "ID");
            dataGridView3.Columns.Add("U_NOMBRE", "Nombre");
            dataGridView3.Columns.Add("U_EMAIL", "Email");
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string nombre = tbUsuario.Text;
            string email = tbGmail.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACIOS.");
                return;
            }

            //GENERAR UN ID INCREMENTABLE
            int nuevoId = dataGridView3.Rows.Count;

            //AÑADIR UN NUEVO USUARIO A LA TABLA
            dataGridView3.Rows.Add(nuevoId, nombre, email);

            //LIMPIAR LOS CAMPOS DE TEXTO
            tbUsuario.Text = "";
            tbGmail.Text = "";

            MessageBox.Show("USUARIO GUARDADO CORRECTAMENTE.");
        }

        private void InitializeDataGridViewTareas()
        {
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add("IDTareas", "ID");
            dataGridView2.Columns.Add("ColumnNombre", "Nombre");
            dataGridView2.Columns.Add("ColumnDescripcion", "Descripción");
            dataGridView2.Columns.Add("ColumnEstado", "Estado");
            dataGridView2.Columns.Add("ColumnHrsTrabajadas", "Horas Trabajadas");
            dataGridView2.Columns.Add("ColumnHrsTotales", "Horas Totales");
            dataGridView2.Columns.Add("ColumnFechaCreacion", "Fecha Creación");

            ButtonEditar = new DataGridViewButtonColumn();
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.HeaderText = "Editar";
            ButtonEditar.Text = "Editar";
            ButtonEditar.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(ButtonEditar);

            ButtonEliminar = new DataGridViewButtonColumn();
            ButtonEliminar.Name = "ButtonEliminar";
            ButtonEliminar.HeaderText = "Eliminar";
            ButtonEliminar.Text = "Eliminar";
            ButtonEliminar.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(ButtonEliminar);
        }

        private void CargarUsuariosEnComboBox()
        {
            comboBoxUsuario.Items.Clear(); // Limpiar los elementos existentes en el ComboBox

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells["U_NOMBRE"] != null && row.Cells["U_ID"] != null)
                {
                    string nombreUsuario = row.Cells["U_NOMBRE"].Value.ToString();
                    int idUsuario = Convert.ToInt32(row.Cells["U_ID"].Value);

                    // Crear un objeto para almacenar el nombre y el ID del usuario
                    comboBoxUsuario.Items.Add(new ComboBoxItem(nombreUsuario, idUsuario));
                }
            }

            if (comboBoxUsuario.Items.Count > 0)
            {
                comboBoxUsuario.SelectedIndex = 0; // Seleccionar el primer usuario por defecto
            }
        }

        // Clase personalizada para almacenar el nombre y el ID del usuario en el ComboBox
        public class ComboBoxItem
        {
            public string Nombre { get; private set; }
            public int Id { get; private set; }

            public ComboBoxItem(string nombre, int id)
            {
                Nombre = nombre;
                Id = id;
            }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }

        // Evento para manejar la selección de un usuario en el ComboBox
        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = comboBoxUsuario.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                int idUsuarioSeleccionado = selectedItem.Id;

                // Aquí puedes manejar lo que sucede cuando se selecciona un usuario, como mostrar más detalles
                MessageBox.Show($"Usuario seleccionado: {selectedItem.Nombre} con ID: {idUsuarioSeleccionado}");
            }
        }
    }
}

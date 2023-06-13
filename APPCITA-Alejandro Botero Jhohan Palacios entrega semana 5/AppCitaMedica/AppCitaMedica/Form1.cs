using AppCitaMedica.model;

namespace AppCitaMedica
{
    public partial class Form1 : Form
    {
        ModelCitaMedica obj_cita = new ModelCitaMedica();
        AdministradorSQL obj_db = new AdministradorSQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            obj_cita.setNombre(textBoxNombre.Text);
            obj_cita.setId(textBoxId.Text);
            obj_cita.setEspecialidad(comboBoxEspecialidad.SelectedItem + "");
            obj_cita.setAgendamiento(PickerAgendamiento.Value);

            String fechaStr = PickerAgendamiento.Value.ToString("yyyy-MM-dd HH:mm");

            obj_cita.setMedico(textBoxMedico.Text);

            obj_db.conectarSQL();
            obj_db.insert(obj_cita.getNombre(), obj_cita.getId(), obj_cita.getEspecialidad(), fechaStr, obj_cita.getMedico());
            cleanRegistro();
            obj_db.closeSQL();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            dataGrid.Rows.Clear();
            obj_db.conectarSQL();
            Console.WriteLine(comboBoxNombres.SelectedItem.ToString());
            obj_cita = obj_db.consulta(comboBoxNombres.SelectedItem.ToString());
            dataGrid.Rows.Add(obj_cita.getNombre(), obj_cita.getId(), obj_cita.getEspecialidad(), obj_cita.getAgendamiento(), obj_cita.getMedico());


            obj_db.closeSQL();
        }



        private void cleanRegistro()
        {
            textBoxNombre.Text = "";
            textBoxId.Text = "";
            comboBoxEspecialidad.Text = "";
            PickerAgendamiento.Text = "";
            textBoxMedico.Text = "";
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "Consulta")
            {
                comboBoxNombres.Items.Clear();
                obj_db.conectarSQL();
                List<String> listaNombres = obj_db.listaConsulta();

                for (int i = 0; i < listaNombres.Count; i++)
                {
                    comboBoxNombres.Items.Add(listaNombres[i]);
                }
                obj_db.closeSQL();

            }

        }


    }
}
namespace AppCitaMedica
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRegistrar = new Button();
            textBoxMedico = new TextBox();
            PickerAgendamiento = new DateTimePicker();
            comboBoxEspecialidad = new ComboBox();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Consulta = new TabPage();
            label6 = new Label();
            dataGrid = new DataGridView();
            comboBoxNombres = new ComboBox();
            btnConsultar = new Button();
            Columna_Nombre = new DataGridViewTextBoxColumn();
            Columna_Id = new DataGridViewTextBoxColumn();
            Columna_Especialidad = new DataGridViewTextBoxColumn();
            Columna_Agendamiento = new DataGridViewTextBoxColumn();
            Columna_Medico = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Consulta);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(764, 494);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(textBoxMedico);
            tabPage1.Controls.Add(PickerAgendamiento);
            tabPage1.Controls.Add(comboBoxEspecialidad);
            tabPage1.Controls.Add(textBoxId);
            tabPage1.Controls.Add(textBoxNombre);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(756, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(335, 394);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 37);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // textBoxMedico
            // 
            textBoxMedico.Location = new Point(307, 324);
            textBoxMedico.Name = "textBoxMedico";
            textBoxMedico.Size = new Size(190, 27);
            textBoxMedico.TabIndex = 9;
            // 
            // PickerAgendamiento
            // 
            PickerAgendamiento.CustomFormat = "yyyy-MM-dd HH:m";
            PickerAgendamiento.Format = DateTimePickerFormat.Custom;
            PickerAgendamiento.ImeMode = ImeMode.On;
            PickerAgendamiento.Location = new Point(307, 225);
            PickerAgendamiento.Name = "PickerAgendamiento";
            PickerAgendamiento.Size = new Size(190, 27);
            PickerAgendamiento.TabIndex = 8;
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Items.AddRange(new object[] { "Medicina General", "Odontologia", "Oncologia", "Ortopedia", "Cardiologia", "Neumologia", "Pediatria", "Psicologia", "Psiquiatria" });
            comboBoxEspecialidad.Location = new Point(307, 156);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(190, 28);
            comboBoxEspecialidad.TabIndex = 7;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(307, 99);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(190, 27);
            textBoxId.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(307, 47);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(190, 27);
            textBoxNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(231, 331);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Médico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 232);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Agendamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 164);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 106);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Identificacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Consulta
            // 
            Consulta.Controls.Add(label6);
            Consulta.Controls.Add(dataGrid);
            Consulta.Controls.Add(comboBoxNombres);
            Consulta.Controls.Add(btnConsultar);
            Consulta.Location = new Point(4, 29);
            Consulta.Name = "Consulta";
            Consulta.Padding = new Padding(3);
            Consulta.Size = new Size(756, 461);
            Consulta.TabIndex = 1;
            Consulta.Text = "Consulta";
            Consulta.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 67);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 4;
            label6.Text = "Nombre";
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.ControlLightLight;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Columna_Nombre, Columna_Id, Columna_Especialidad, Columna_Agendamiento, Columna_Medico });
            dataGrid.Location = new Point(39, 134);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(679, 237);
            dataGrid.TabIndex = 3;
            // 
            // comboBoxNombres
            // 
            comboBoxNombres.FormattingEnabled = true;
            comboBoxNombres.Location = new Point(235, 59);
            comboBoxNombres.Name = "comboBoxNombres";
            comboBoxNombres.Size = new Size(308, 28);
            comboBoxNombres.TabIndex = 2;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(331, 391);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(89, 37);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Columna_Nombre
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Columna_Nombre.DefaultCellStyle = dataGridViewCellStyle1;
            Columna_Nombre.HeaderText = "Nombre";
            Columna_Nombre.MinimumWidth = 6;
            Columna_Nombre.Name = "Columna_Nombre";
            Columna_Nombre.Width = 125;
            // 
            // Columna_Id
            // 
            Columna_Id.HeaderText = "Identificación";
            Columna_Id.MinimumWidth = 6;
            Columna_Id.Name = "Columna_Id";
            Columna_Id.Width = 125;
            // 
            // Columna_Especialidad
            // 
            Columna_Especialidad.HeaderText = "Especialidad";
            Columna_Especialidad.MinimumWidth = 6;
            Columna_Especialidad.Name = "Columna_Especialidad";
            Columna_Especialidad.Width = 125;
            // 
            // Columna_Agendamiento
            // 
            Columna_Agendamiento.HeaderText = "Fecha y Hora";
            Columna_Agendamiento.MinimumWidth = 6;
            Columna_Agendamiento.Name = "Columna_Agendamiento";
            Columna_Agendamiento.Width = 125;
            // 
            // Columna_Medico
            // 
            Columna_Medico.HeaderText = "Médico";
            Columna_Medico.MinimumWidth = 6;
            Columna_Medico.Name = "Columna_Medico";
            Columna_Medico.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 497);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Consulta.ResumeLayout(false);
            Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Consulta;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker PickerAgendamiento;
        private ComboBox comboBoxEspecialidad;
        private TextBox textBoxId;
        private TextBox textBoxNombre;
        private TextBox textBoxMedico;
        private Button btnRegistrar;
        private Button btnConsultar;
        private ComboBox comboBoxNombres;
        private Label label6;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Columna_Nombre;
        private DataGridViewTextBoxColumn Columna_Id;
        private DataGridViewTextBoxColumn Columna_Especialidad;
        private DataGridViewTextBoxColumn Columna_Agendamiento;
        private DataGridViewTextBoxColumn Columna_Medico;
    }
}
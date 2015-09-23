namespace frmInicio
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcMedicos = new System.Windows.Forms.TabControl();
            this.tpMedicos = new System.Windows.Forms.TabPage();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.cmsMedicos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpPaciente = new System.Windows.Forms.TabPage();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.cmsPacientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGenerarTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTelefonoP = new System.Windows.Forms.TextBox();
            this.tbDniP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbApellidoP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBuscarP = new System.Windows.Forms.TextBox();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnListarP = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.btnCargarP = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTurnos = new System.Windows.Forms.TabPage();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFecha = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEspecialidadMenuT = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbClaveConfirm = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.cmsUsuario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTurnos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.confirmarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMedicos.SuspendLayout();
            this.tpMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.cmsMedicos.SuspendLayout();
            this.tpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.cmsPacientes.SuspendLayout();
            this.tbTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.tpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.cmsUsuario.SuspendLayout();
            this.cmsTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMedicos
            // 
            this.tcMedicos.Controls.Add(this.tpMedicos);
            this.tcMedicos.Controls.Add(this.tpPaciente);
            this.tcMedicos.Controls.Add(this.tbTurnos);
            this.tcMedicos.Controls.Add(this.tpUsuarios);
            this.tcMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMedicos.Location = new System.Drawing.Point(0, 0);
            this.tcMedicos.Name = "tcMedicos";
            this.tcMedicos.SelectedIndex = 0;
            this.tcMedicos.Size = new System.Drawing.Size(924, 331);
            this.tcMedicos.TabIndex = 0;
            // 
            // tpMedicos
            // 
            this.tpMedicos.BackgroundImage = global::frmInicio.Properties.Resources.Medicina_personalizada;
            this.tpMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpMedicos.Controls.Add(this.btnCargar);
            this.tpMedicos.Controls.Add(this.tbMatricula);
            this.tpMedicos.Controls.Add(this.tbApellido);
            this.tpMedicos.Controls.Add(this.tbNombre);
            this.tpMedicos.Controls.Add(this.tbDocumento);
            this.tpMedicos.Controls.Add(this.label2);
            this.tpMedicos.Controls.Add(this.cbEspecialidad);
            this.tpMedicos.Controls.Add(this.label6);
            this.tpMedicos.Controls.Add(this.label5);
            this.tpMedicos.Controls.Add(this.label3);
            this.tpMedicos.Controls.Add(this.label1);
            this.tpMedicos.Controls.Add(this.dgvMedicos);
            this.tpMedicos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMedicos.Location = new System.Drawing.Point(4, 22);
            this.tpMedicos.Name = "tpMedicos";
            this.tpMedicos.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedicos.Size = new System.Drawing.Size(916, 305);
            this.tpMedicos.TabIndex = 0;
            this.tpMedicos.Text = "Medicos";
            this.tpMedicos.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Location = new System.Drawing.Point(380, 104);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(156, 34);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMatricula.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatricula.Location = new System.Drawing.Point(32, 55);
            this.tbMatricula.MaxLength = 6;
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(100, 26);
            this.tbMatricula.TabIndex = 1;
            this.tbMatricula.Tag = "Matrícula";
            this.tbMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbApellido.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(523, 55);
            this.tbApellido.MaxLength = 30;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(161, 26);
            this.tbApellido.TabIndex = 4;
            this.tbApellido.Tag = "Apellido";
            this.tbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbNombre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(320, 55);
            this.tbNombre.MaxLength = 30;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(167, 26);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.Tag = "Nombre";
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // tbDocumento
            // 
            this.tbDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDocumento.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumento.Location = new System.Drawing.Point(168, 55);
            this.tbDocumento.MaxLength = 8;
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(116, 26);
            this.tbDocumento.TabIndex = 2;
            this.tbDocumento.Tag = "Documento";
            this.tbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(33, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrícula";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEspecialidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Alergología",
            "Cirugía",
            "Cirugía vascular",
            "Clínico",
            "Farmacología",
            "Geriatría",
            "Hidrología",
            "Infectología",
            "Microbiología",
            "Neumología",
            "Oftalmología",
            "Ortopedia",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Radiología",
            "Rehabilitación",
            "Traumatología"});
            this.cbEspecialidad.Location = new System.Drawing.Point(720, 55);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(165, 26);
            this.cbEspecialidad.Sorted = true;
            this.cbEspecialidad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(738, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(559, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(369, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento";
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AllowUserToResizeRows = false;
            this.dgvMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.ContextMenuStrip = this.cmsMedicos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicos.Location = new System.Drawing.Point(0, 144);
            this.dgvMedicos.MultiSelect = false;
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.ReadOnly = true;
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.Size = new System.Drawing.Size(916, 161);
            this.dgvMedicos.TabIndex = 0;
            // 
            // cmsMedicos
            // 
            this.cmsMedicos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsMedicos.Name = "cmsMedicos";
            this.cmsMedicos.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // tpPaciente
            // 
            this.tpPaciente.BackgroundImage = global::frmInicio.Properties.Resources.Medicina_personalizada;
            this.tpPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpPaciente.Controls.Add(this.dgvPacientes);
            this.tpPaciente.Controls.Add(this.tbTelefonoP);
            this.tpPaciente.Controls.Add(this.tbDniP);
            this.tpPaciente.Controls.Add(this.label15);
            this.tpPaciente.Controls.Add(this.tbApellidoP);
            this.tpPaciente.Controls.Add(this.label14);
            this.tpPaciente.Controls.Add(this.tbBuscarP);
            this.tpPaciente.Controls.Add(this.tbNombreP);
            this.tpPaciente.Controls.Add(this.label13);
            this.tpPaciente.Controls.Add(this.btnListarP);
            this.tpPaciente.Controls.Add(this.btnBuscarP);
            this.tpPaciente.Controls.Add(this.btnCargarP);
            this.tpPaciente.Controls.Add(this.label16);
            this.tpPaciente.Controls.Add(this.label12);
            this.tpPaciente.Location = new System.Drawing.Point(4, 22);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaciente.Size = new System.Drawing.Size(916, 305);
            this.tpPaciente.TabIndex = 3;
            this.tpPaciente.Text = "Paciente";
            this.tpPaciente.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.ContextMenuStrip = this.cmsPacientes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPacientes.Location = new System.Drawing.Point(3, 168);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(910, 134);
            this.dgvPacientes.TabIndex = 14;
            // 
            // cmsPacientes
            // 
            this.cmsPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerarTurno,
            this.eliminarToolStripMenuItem3});
            this.cmsPacientes.Name = "cmsPacientes";
            this.cmsPacientes.Size = new System.Drawing.Size(151, 48);
            // 
            // btnGenerarTurno
            // 
            this.btnGenerarTurno.Name = "btnGenerarTurno";
            this.btnGenerarTurno.Size = new System.Drawing.Size(150, 22);
            this.btnGenerarTurno.Text = "Generar Turno";
            this.btnGenerarTurno.Click += new System.EventHandler(this.btnGenerarTurno_Click);
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            this.eliminarToolStripMenuItem3.Click += new System.EventHandler(this.eliminarToolStripMenuItem3_Click);
            // 
            // tbTelefonoP
            // 
            this.tbTelefonoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbTelefonoP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoP.Location = new System.Drawing.Point(722, 49);
            this.tbTelefonoP.MaxLength = 14;
            this.tbTelefonoP.Name = "tbTelefonoP";
            this.tbTelefonoP.Size = new System.Drawing.Size(139, 26);
            this.tbTelefonoP.TabIndex = 4;
            this.tbTelefonoP.Tag = "Telefono";
            this.tbTelefonoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // tbDniP
            // 
            this.tbDniP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDniP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDniP.Location = new System.Drawing.Point(500, 49);
            this.tbDniP.MaxLength = 8;
            this.tbDniP.Name = "tbDniP";
            this.tbDniP.Size = new System.Drawing.Size(148, 26);
            this.tbDniP.TabIndex = 3;
            this.tbDniP.Tag = "Documento";
            this.tbDniP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(747, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 18);
            this.label15.TabIndex = 11;
            this.label15.Text = "Telefono";
            // 
            // tbApellidoP
            // 
            this.tbApellidoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbApellidoP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoP.Location = new System.Drawing.Point(268, 50);
            this.tbApellidoP.Name = "tbApellidoP";
            this.tbApellidoP.Size = new System.Drawing.Size(153, 26);
            this.tbApellidoP.TabIndex = 2;
            this.tbApellidoP.Tag = "Apellido";
            this.tbApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(525, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "Documento";
            // 
            // tbBuscarP
            // 
            this.tbBuscarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbBuscarP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscarP.Location = new System.Drawing.Point(241, 136);
            this.tbBuscarP.MaxLength = 8;
            this.tbBuscarP.Name = "tbBuscarP";
            this.tbBuscarP.Size = new System.Drawing.Size(132, 26);
            this.tbBuscarP.TabIndex = 6;
            this.tbBuscarP.Tag = "no";
            this.tbBuscarP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatricula_KeyPress);
            // 
            // tbNombreP
            // 
            this.tbNombreP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbNombreP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreP.Location = new System.Drawing.Point(56, 49);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(145, 26);
            this.tbNombreP.TabIndex = 1;
            this.tbNombreP.Tag = "Nombre";
            this.tbNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellido_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(300, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Apellido";
            // 
            // btnListarP
            // 
            this.btnListarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnListarP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarP.Location = new System.Drawing.Point(528, 128);
            this.btnListarP.Name = "btnListarP";
            this.btnListarP.Size = new System.Drawing.Size(100, 40);
            this.btnListarP.TabIndex = 7;
            this.btnListarP.Text = "Listar";
            this.btnListarP.UseVisualStyleBackColor = false;
            this.btnListarP.Click += new System.EventHandler(this.btnListarP_Click);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarP.Location = new System.Drawing.Point(408, 128);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(100, 40);
            this.btnBuscarP.TabIndex = 7;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
            // 
            // btnCargarP
            // 
            this.btnCargarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCargarP.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarP.Location = new System.Drawing.Point(408, 82);
            this.btnCargarP.Name = "btnCargarP";
            this.btnCargarP.Size = new System.Drawing.Size(100, 40);
            this.btnCargarP.TabIndex = 5;
            this.btnCargarP.Text = "Cargar";
            this.btnCargarP.UseVisualStyleBackColor = false;
            this.btnCargarP.Click += new System.EventHandler(this.btnCargarP_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label16.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 18);
            this.label16.TabIndex = 13;
            this.label16.Text = "Buscar por Documento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(94, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nombre";
            // 
            // tbTurnos
            // 
            this.tbTurnos.BackgroundImage = global::frmInicio.Properties.Resources.Medicina_personalizada;
            this.tbTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTurnos.Controls.Add(this.dgvTurnos);
            this.tbTurnos.Controls.Add(this.label8);
            this.tbTurnos.Controls.Add(this.label7);
            this.tbTurnos.Controls.Add(this.label4);
            this.tbTurnos.Controls.Add(this.cbFecha);
            this.tbTurnos.Controls.Add(this.dtpFecha);
            this.tbTurnos.Controls.Add(this.cbEspecialidadMenuT);
            this.tbTurnos.Controls.Add(this.cbMedicos);
            this.tbTurnos.Location = new System.Drawing.Point(4, 22);
            this.tbTurnos.Name = "tbTurnos";
            this.tbTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tbTurnos.Size = new System.Drawing.Size(916, 305);
            this.tbTurnos.TabIndex = 1;
            this.tbTurnos.Text = "Turnos";
            this.tbTurnos.UseVisualStyleBackColor = true;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            this.dgvTurnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.ContextMenuStrip = this.cmsTurnos;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTurnos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTurnos.Location = new System.Drawing.Point(3, 87);
            this.dgvTurnos.MultiSelect = false;
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersVisible = false;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(910, 215);
            this.dgvTurnos.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(717, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Medico";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especialidad";
            // 
            // cbFecha
            // 
            this.cbFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFecha.AutoSize = true;
            this.cbFecha.Enabled = false;
            this.cbFecha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFecha.Location = new System.Drawing.Point(847, 49);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(15, 14);
            this.cbFecha.TabIndex = 2;
            this.cbFecha.UseVisualStyleBackColor = true;
            this.cbFecha.CheckedChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(640, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.cbFecha_CheckedChanged);
            // 
            // cbEspecialidadMenuT
            // 
            this.cbEspecialidadMenuT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEspecialidadMenuT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEspecialidadMenuT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEspecialidadMenuT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidadMenuT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidadMenuT.FormattingEnabled = true;
            this.cbEspecialidadMenuT.Items.AddRange(new object[] {
            "Alergología",
            "Cirugía",
            "Cirugía vascular",
            "Clínico",
            "Farmacología",
            "Geriatría",
            "Hidrología",
            "Infectología",
            "Microbiología",
            "Neumología",
            "Oftalmología",
            "Ortopedia",
            "Otorrinolaringología",
            "Pediatría",
            "Psiquiatría",
            "Radiología",
            "Rehabilitación",
            "Traumatología"});
            this.cbEspecialidadMenuT.Location = new System.Drawing.Point(54, 43);
            this.cbEspecialidadMenuT.Name = "cbEspecialidadMenuT";
            this.cbEspecialidadMenuT.Size = new System.Drawing.Size(266, 26);
            this.cbEspecialidadMenuT.TabIndex = 0;
            this.cbEspecialidadMenuT.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadTurnos_SelectedIndexChanged);
            // 
            // cbMedicos
            // 
            this.cbMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMedicos.Enabled = false;
            this.cbMedicos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(351, 43);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(258, 26);
            this.cbMedicos.TabIndex = 0;
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackgroundImage = global::frmInicio.Properties.Resources.Medicina_personalizada;
            this.tpUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpUsuarios.Controls.Add(this.label11);
            this.tpUsuarios.Controls.Add(this.label10);
            this.tpUsuarios.Controls.Add(this.label9);
            this.tpUsuarios.Controls.Add(this.tbClaveConfirm);
            this.tpUsuarios.Controls.Add(this.tbClave);
            this.tpUsuarios.Controls.Add(this.tbUsuario);
            this.tpUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tpUsuarios.Controls.Add(this.dgvUsuarios);
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(916, 305);
            this.tpUsuarios.TabIndex = 2;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Clave";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Confirmar Clave";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Usuario";
            // 
            // tbClaveConfirm
            // 
            this.tbClaveConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbClaveConfirm.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClaveConfirm.Location = new System.Drawing.Point(334, 46);
            this.tbClaveConfirm.Name = "tbClaveConfirm";
            this.tbClaveConfirm.Size = new System.Drawing.Size(100, 26);
            this.tbClaveConfirm.TabIndex = 3;
            this.tbClaveConfirm.Tag = "Confirmar Clave";
            this.tbClaveConfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClaveConfirm_KeyPress);
            // 
            // tbClave
            // 
            this.tbClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbClave.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClave.Location = new System.Drawing.Point(177, 46);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(100, 26);
            this.tbClave.TabIndex = 2;
            this.tbClave.Tag = "Clave";
            this.tbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClaveConfirm_KeyPress);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbUsuario.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(18, 46);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 26);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Tag = "Usuario";
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClaveConfirm_KeyPress);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(261, 143);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(142, 40);
            this.btnAgregarUsuario.TabIndex = 4;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.ContextMenuStrip = this.cmsUsuario;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUsuarios.Location = new System.Drawing.Point(593, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(320, 299);
            this.dgvUsuarios.TabIndex = 8;
            // 
            // cmsUsuario
            // 
            this.cmsUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem2});
            this.cmsUsuario.Name = "cmsUsuario";
            this.cmsUsuario.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem2
            // 
            this.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            this.eliminarToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem2.Text = "Eliminar";
            this.eliminarToolStripMenuItem2.Click += new System.EventHandler(this.eliminarToolStripMenuItem2_Click);
            // 
            // cmsTurnos
            // 
            this.cmsTurnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmarAsistenciaToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.cmsTurnos.Name = "cmsUsuario";
            this.cmsTurnos.Size = new System.Drawing.Size(185, 48);
            // 
            // confirmarAsistenciaToolStripMenuItem
            // 
            this.confirmarAsistenciaToolStripMenuItem.Name = "confirmarAsistenciaToolStripMenuItem";
            this.confirmarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.confirmarAsistenciaToolStripMenuItem.Text = "Confirmar Asistencia";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 331);
            this.Controls.Add(this.tcMedicos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(940, 370);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tcMedicos.ResumeLayout(false);
            this.tpMedicos.ResumeLayout(false);
            this.tpMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.cmsMedicos.ResumeLayout(false);
            this.tpPaciente.ResumeLayout(false);
            this.tpPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.cmsPacientes.ResumeLayout(false);
            this.tbTurnos.ResumeLayout(false);
            this.tbTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.tpUsuarios.ResumeLayout(false);
            this.tpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.cmsUsuario.ResumeLayout(false);
            this.cmsTurnos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMedicos;
        private System.Windows.Forms.TabPage tpMedicos;
        private System.Windows.Forms.TabPage tbTurnos;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ContextMenuStrip cmsMedicos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbEspecialidadMenuT;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbClaveConfirm;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tpPaciente;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox tbTelefonoP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbApellidoP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.Button btnCargarP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDniP;
        private System.Windows.Forms.TextBox tbBuscarP;
        private System.Windows.Forms.ContextMenuStrip cmsUsuario;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem2;
        private System.Windows.Forms.Button btnListarP;
        private System.Windows.Forms.ContextMenuStrip cmsPacientes;
        private System.Windows.Forms.ToolStripMenuItem btnGenerarTurno;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip cmsTurnos;
        private System.Windows.Forms.ToolStripMenuItem confirmarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;


    }
}
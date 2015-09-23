namespace frmInicio
{
    partial class frmTurno
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
            this.cbEspecialidadT = new System.Windows.Forms.ComboBox();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarT = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEspecialidadT
            // 
            this.cbEspecialidadT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEspecialidadT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEspecialidadT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecialidadT.FormattingEnabled = true;
            this.cbEspecialidadT.Items.AddRange(new object[] {
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
            this.cbEspecialidadT.Location = new System.Drawing.Point(173, 62);
            this.cbEspecialidadT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbEspecialidadT.Name = "cbEspecialidadT";
            this.cbEspecialidadT.Size = new System.Drawing.Size(304, 26);
            this.cbEspecialidadT.TabIndex = 0;
            this.cbEspecialidadT.Tag = "especialidad";
            this.cbEspecialidadT.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidad_SelectedIndexChanged);
            // 
            // cbMedicos
            // 
            this.cbMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbMedicos.Enabled = false;
            this.cbMedicos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(173, 138);
            this.cbMedicos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(304, 26);
            this.cbMedicos.TabIndex = 0;
            this.cbMedicos.SelectedIndexChanged += new System.EventHandler(this.cbMedicos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Medico";
            // 
            // btnGuardarT
            // 
            this.btnGuardarT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarT.Enabled = false;
            this.btnGuardarT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarT.Location = new System.Drawing.Point(246, 311);
            this.btnGuardarT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardarT.Name = "btnGuardarT";
            this.btnGuardarT.Size = new System.Drawing.Size(173, 54);
            this.btnGuardarT.TabIndex = 3;
            this.btnGuardarT.Text = "Guardar";
            this.btnGuardarT.UseVisualStyleBackColor = false;
            this.btnGuardarT.Click += new System.EventHandler(this.btnGuardarT_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(132, 195);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(394, 26);
            this.dtpFecha.TabIndex = 4;
            // 
            // nudHoras
            // 
            this.nudHoras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudHoras.Enabled = false;
            this.nudHoras.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoras.Location = new System.Drawing.Point(246, 245);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudHoras.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudHoras.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.ReadOnly = true;
            this.nudHoras.Size = new System.Drawing.Size(45, 26);
            this.nudHoras.TabIndex = 5;
            this.nudHoras.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nudMinutos
            // 
            this.nudMinutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudMinutos.Enabled = false;
            this.nudMinutos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinutos.Location = new System.Drawing.Point(445, 245);
            this.nudMinutos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudMinutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.ReadOnly = true;
            this.nudMinutos.Size = new System.Drawing.Size(45, 26);
            this.nudMinutos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutos";
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmInicio.Properties.Resources.quiro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 378);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardarT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.cbEspecialidadT);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(667, 417);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(667, 417);
            this.Name = "frmTurno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEspecialidadT;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarT;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
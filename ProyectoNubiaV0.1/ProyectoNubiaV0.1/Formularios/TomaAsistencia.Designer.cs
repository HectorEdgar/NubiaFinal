namespace ProyectoNubiaV0._1.Formularios
{
    partial class TomaAsistencia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarAsistencia = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cbGrupoGimnasio = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.NombreAlumno,
            this.Asistencia});
            this.dataGridView1.Location = new System.Drawing.Point(26, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.HeaderText = "Nombre del alumno";
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.ReadOnly = true;
            // 
            // Asistencia
            // 
            this.Asistencia.FalseValue = "falta";
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.IndeterminateValue = "retardo";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ThreeState = true;
            this.Asistencia.TrueValue = "asistencia";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarAsistencia);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 222);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGuardarAsistencia
            // 
            this.btnGuardarAsistencia.Location = new System.Drawing.Point(141, 185);
            this.btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            this.btnGuardarAsistencia.Size = new System.Drawing.Size(110, 23);
            this.btnGuardarAsistencia.TabIndex = 2;
            this.btnGuardarAsistencia.Text = "Tomar Asistencia";
            this.btnGuardarAsistencia.UseVisualStyleBackColor = true;
            this.btnGuardarAsistencia.Click += new System.EventHandler(this.btnGuardarAsistencia_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(13, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbGrupoGimnasio
            // 
            this.cbGrupoGimnasio.FormattingEnabled = true;
            this.cbGrupoGimnasio.Location = new System.Drawing.Point(378, 12);
            this.cbGrupoGimnasio.Name = "cbGrupoGimnasio";
            this.cbGrupoGimnasio.Size = new System.Drawing.Size(121, 21);
            this.cbGrupoGimnasio.TabIndex = 4;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(518, 12);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 21);
            this.cbHorario.TabIndex = 5;
            // 
            // TomaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 428);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.cbGrupoGimnasio);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.Name = "TomaAsistencia";
            this.Text = "TomaAsistenci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TomaAsistencia_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
        private System.Windows.Forms.ComboBox cbGrupoGimnasio;
        private System.Windows.Forms.ComboBox cbHorario;
    }
}
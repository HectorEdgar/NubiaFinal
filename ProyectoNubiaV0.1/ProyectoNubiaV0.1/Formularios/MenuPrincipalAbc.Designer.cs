namespace ProyectoNubiaV0._1.Formularios
{
    partial class MenuPrincipalAbc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresarMenuPrincipal = new System.Windows.Forms.Button();
            this.AbcHorario = new System.Windows.Forms.Button();
            this.ABCGruposGimnasio = new System.Windows.Forms.Button();
            this.btnAbcAlumnos = new System.Windows.Forms.Button();
            this.btnAbcAsistencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegresarMenuPrincipal);
            this.panel1.Controls.Add(this.AbcHorario);
            this.panel1.Controls.Add(this.ABCGruposGimnasio);
            this.panel1.Controls.Add(this.btnAbcAlumnos);
            this.panel1.Controls.Add(this.btnAbcAsistencia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 257);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresarMenuPrincipal
            // 
            this.btnRegresarMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.btnRegresarMenuPrincipal.Name = "btnRegresarMenuPrincipal";
            this.btnRegresarMenuPrincipal.Size = new System.Drawing.Size(73, 23);
            this.btnRegresarMenuPrincipal.TabIndex = 5;
            this.btnRegresarMenuPrincipal.Text = "Regresar";
            this.btnRegresarMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnRegresarMenuPrincipal.Click += new System.EventHandler(this.btnRegresarMenuPrincipal_Click);
            // 
            // AbcHorario
            // 
            this.AbcHorario.Location = new System.Drawing.Point(28, 179);
            this.AbcHorario.Name = "AbcHorario";
            this.AbcHorario.Size = new System.Drawing.Size(140, 23);
            this.AbcHorario.TabIndex = 4;
            this.AbcHorario.Text = "ABC Horarios";
            this.AbcHorario.UseVisualStyleBackColor = true;
            this.AbcHorario.Click += new System.EventHandler(this.AbcHorario_Click);
            // 
            // ABCGruposGimnasio
            // 
            this.ABCGruposGimnasio.Location = new System.Drawing.Point(28, 208);
            this.ABCGruposGimnasio.Name = "ABCGruposGimnasio";
            this.ABCGruposGimnasio.Size = new System.Drawing.Size(140, 23);
            this.ABCGruposGimnasio.TabIndex = 3;
            this.ABCGruposGimnasio.Text = "ABC Grupos del Gimnasio";
            this.ABCGruposGimnasio.UseVisualStyleBackColor = true;
            this.ABCGruposGimnasio.Click += new System.EventHandler(this.ABCGruposGimnasio_Click);
            // 
            // btnAbcAlumnos
            // 
            this.btnAbcAlumnos.Location = new System.Drawing.Point(28, 150);
            this.btnAbcAlumnos.Name = "btnAbcAlumnos";
            this.btnAbcAlumnos.Size = new System.Drawing.Size(140, 23);
            this.btnAbcAlumnos.TabIndex = 2;
            this.btnAbcAlumnos.Text = "ABC Alumnos";
            this.btnAbcAlumnos.UseVisualStyleBackColor = true;
            this.btnAbcAlumnos.Click += new System.EventHandler(this.btnAbcAlumnos_Click);
            // 
            // btnAbcAsistencia
            // 
            this.btnAbcAsistencia.Location = new System.Drawing.Point(28, 120);
            this.btnAbcAsistencia.Name = "btnAbcAsistencia";
            this.btnAbcAsistencia.Size = new System.Drawing.Size(140, 23);
            this.btnAbcAsistencia.TabIndex = 1;
            this.btnAbcAsistencia.Text = "ABC Asistencias";
            this.btnAbcAsistencia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu ABC";
            // 
            // MenuPrincipalAbc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 319);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipalAbc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipalAbc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipalAbc_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AbcHorario;
        private System.Windows.Forms.Button ABCGruposGimnasio;
        private System.Windows.Forms.Button btnAbcAlumnos;
        private System.Windows.Forms.Button btnAbcAsistencia;
        private System.Windows.Forms.Button btnRegresarMenuPrincipal;
    }
}
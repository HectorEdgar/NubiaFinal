using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Formularios
{
    public partial class TomaAsistencia : Form
    {
        public TomaAsistencia()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add(
                "1",
                "Hector",
                true

                );
            this.dataGridView1.Rows.Add(
                "2",
                "Edgar",
                false

                );
        }

        private void TomaAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing))
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipal"].Visible = true;
            this.Dispose();
        }

        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    MessageBox.Show( dataGridView1.Rows[i].Cells[j].Value+"");
                }
            }

            MessageBox.Show(DateTime.Now.ToString()+DateTime.Now.DayOfWeek);
            MessageBox.Show(DateTime.Now.ToString() + DateTime.Now.AddDays(3).DayOfWeek);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

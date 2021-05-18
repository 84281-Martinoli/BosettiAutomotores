using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms.InvoiceCRUD
{
    public partial class Gestor_Alertas : Form
    {
        public Gestor_Alertas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstablecerMin_Click(object sender, EventArgs e)
        {
            if (txtCantMin.Text.Equals("") || txtPorcMin.Text.Equals(""))
            {
                MessageBox.Show("No establecio Valores para los minimos");
            }
            else
            {
                string id = txtId.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string cantMin = txtCantMin.Text.Trim();
                string porcMin = txtPorcMin.Text.Trim();
            }
        }

        private void dataGridRepuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnEstablecerMin.Enabled = true;
            

        }
    }
}

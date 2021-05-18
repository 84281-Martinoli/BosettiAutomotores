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
    public partial class Gestionar_Insumos : Form
    {
        public Gestionar_Insumos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string id = txtIdRepuesto.Text.Trim();
            string nombre = txtNombreRepuesto.Text.Trim();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txtIdRepuesto.Text.Trim();
            string nombre = txtNombreRepuesto.Text.Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdRepuesto.Text.Equals("") && txtNombreRepuesto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese Un dato para realizar la busqueda");
            }
            else
            {
                string id = txtIdRepuesto.Text.Trim();
                string nombre = txtNombreRepuesto.Text.Trim();
            }

        }

        private void Gestionar_Insumos_Load(object sender, EventArgs e)
        {

        }
    }
}

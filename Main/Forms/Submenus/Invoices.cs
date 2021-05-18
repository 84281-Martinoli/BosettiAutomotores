using Main.Forms.InvoiceCRUD;
using System;
using System.Windows.Forms;

namespace Main.Forms {
	public partial class Invoices : Form {
		public Invoices() => InitializeComponent();

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Clientes fh = new Clientes();
            fh.ShowDialog();
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            Generar_presupuesto fh = new Generar_presupuesto();
            fh.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial_ventas fh = new Historial_ventas();
            fh.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Clientes fh = new Clientes();
            fh.ShowDialog();
        }
    }
}

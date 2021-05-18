using Main.Forms.InvoiceCRUD;
using System.Windows.Forms;

namespace Main.Forms {
	public partial class Stock : Form {
		public Stock() => InitializeComponent();

        private void btnStockWindows_Click(object sender, System.EventArgs e)
        {
            Mostrar_Inventario fh = new Mostrar_Inventario();
            fh.ShowDialog();
        }

        private void btnInsumos_Click(object sender, System.EventArgs e)
        {
            Gestionar_Insumos fh = new Gestionar_Insumos();
            fh.ShowDialog();
        }

        private void btnInventario_Click(object sender, System.EventArgs e)
        {
            Gestion_Inventario fh = new Gestion_Inventario();
            fh.ShowDialog();
        }

        private void btnAlertas_Click(object sender, System.EventArgs e)
        {
            Gestor_Alertas fh = new Gestor_Alertas();
            fh.ShowDialog();
        }
    }
}

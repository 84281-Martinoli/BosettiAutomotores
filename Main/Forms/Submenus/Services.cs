using Main.Forms.ServiceForm;
using System;
using System.Windows.Forms;

namespace Main.Forms {
	public partial class Services : Form {
		public Services() => InitializeComponent();

        private void progressButton_Click(object sender, EventArgs e)
        {
            ActiveService fh = new ActiveService();
            fh.ShowDialog();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            AddServices fh = new AddServices();
            fh.ShowDialog();
        }
    }
}

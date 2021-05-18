using System;
using System.Windows.Forms;
using Utilities;
using DataAccessLayer;

namespace Main.Forms {
	public partial class CreateService : Form {
		public CreateService() => InitializeComponent();

		private void buttonCancel_Click(object sender, EventArgs e) => Close();

		private void cleanButton_Click(object sender, EventArgs e) => Generics.CleanFields(this);

		private void buttonCreateClient_Click(object sender, EventArgs e) => ClientAdapter.Create(System.Configuration.ConfigurationManager.AppSettings["Connection"], textBoxClientName.Text.Trim(), textBoxClientSurname.Text.Trim(), textBoxClientDocument.Text.Trim());

		private void CreateService_Load(object sender, EventArgs e) => refresh();

		private void refresh() {
			Generics.LoadComboBox(System.Configuration.ConfigurationManager.AppSettings["Connection"], "Automoviles", "id_modelo", "id_automovil", comboBoxCarModel);
			Generics.LoadComboBox(System.Configuration.ConfigurationManager.AppSettings["Connection"], "Automoviles", "serie", "id_automovil", comboBoxCarVersion);
			Generics.LoadComboBox(System.Configuration.ConfigurationManager.AppSettings["Connection"], "Automoviles", "año", "id_automovil", comboBoxCarYear);
			Generics.LoadComboBox(System.Configuration.ConfigurationManager.AppSettings["Connection"], "TipoDeServicios", "nombre_servicio", "id_tipo_servicio", comboBoxTypeWork);
			Generics.LoadComboBox(System.Configuration.ConfigurationManager.AppSettings["Connection"], "Empleados", "numero_documento", "numero_documento", comboBoxMechanic);
		}

		private void buttonCreateService_Click(object sender, EventArgs e) {
			if (dataGridViewParts.SelectedRows.Count < 0) return;

			ServiceAdapter.CreateService(System.Configuration.ConfigurationManager.AppSettings["Connection"], , comboBoxCarVersion.SelectedItem.ToString(), comboBoxCarYear.SelectedItem.ToString(), textBoxCarKm.Text.Trim(), comboBoxTypeWork.SelectedItem.ToString(), comboBoxMechanic.SelectedItem.ToString());

			refresh();
		}
	}
}

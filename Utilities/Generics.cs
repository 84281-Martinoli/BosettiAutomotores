using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Utilities {
	public static class Generics {

		/// <summary>
		/// Returns true if the element is already in the DataGridView.
		/// </summary>
		/// <param name="element">The element to be searched.</param>
		/// <param name="dataGridView">The DataGridView to check.</param>
		/// <param name="field">The name of the field in the DataGridView.</param>
		/// <returns>A boolean representing the presence of the element in the DataGridView.</returns>
		public static bool IsAlreadyInGrid(string element, DataGridView dataGridView, string field) {
			if (dataGridView.Rows.Count > 1) {
				foreach (DataGridViewRow row in dataGridView.Rows) {
					if (row.Cells[field].Value != null && row.Cells[field].Value.Equals(element)) return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Returns the index of the selected RadioButton or -1 if none was found.
		/// </summary>
		/// <param name="panel">The Panel with the RadioButtons.</param>
		/// <param name="elements">A string List containing the Text property of the RadioButtons.</param>
		/// <returns>An integer representing the index of the RadioButton selected on a Panel.</returns>
		public static int CheckedComboBox(Panel panel, List<string> elements) => elements.IndexOf(panel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text);

		/// <summary>
		/// Fills the ComboBoxes with the data inside the SQL table.
		/// </summary>
		/// <param name="table">A string representing the name of the SQL table.</param>
		/// <param name="attribute">A string representing the name of the SQL table's attribute.</param>
		/// <param name="comboBox">The ComboBox to be filled.</param>
		public static void LoadComboBox(string ip, string table, string attribute, string id, ComboBox comboBox) {
			using var conn = new SqlConnection(ip);
			conn.Open();

			using var cmd = new SqlCommand($"SELECT * FROM {table}", conn);
			using var dataAdapter = new SqlDataAdapter(cmd);

			var dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			comboBox.DataSource = table;
			comboBox.DisplayMember = attribute;
			comboBox.ValueMember = id;
		}

		/// <summary>
		/// Cleans the fields of a Form.
		/// </summary>
		/// <param name="form">The Form to be cleaned.</param>
		public static void CleanFields(Form form) {
			foreach (var element in form.Controls) {
				switch (element) {
					case TextBox textBox:
						textBox.ResetText();
						break;
					case MaskedTextBox maskedTextBox:
						maskedTextBox.ResetText();
						break;
					case RadioButton radioButton:
						radioButton.Checked = false;
						break;
					case CheckBox checkBox:
						checkBox.Checked = false;
						break;
					case ComboBox comboBox:
						comboBox.SelectedIndex = -1;
						break;
				}
			}
		}

		/// <summary>
		/// Shows an error message and restores the focus. Usually called after CleanFields().
		/// </summary>
		/// <param name="message">A string containing the message</param>
		/// <param name="element">The element to be focused.</param>
		public static void WrongInput(string message, Control element) {
			MessageBox.Show(message);

			element.Focus();
		}
	}
}



namespace Main.Forms {
	partial class CreateService {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panelTop = new System.Windows.Forms.Panel();
			this.buttonAddService = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelClientName = new System.Windows.Forms.Label();
			this.textBoxClientName = new System.Windows.Forms.TextBox();
			this.buttonClientSearch = new System.Windows.Forms.Button();
			this.buttonCreateClient = new System.Windows.Forms.Button();
			this.textBoxClientSurname = new System.Windows.Forms.TextBox();
			this.labelClientSurname = new System.Windows.Forms.Label();
			this.textBoxClientDocument = new System.Windows.Forms.TextBox();
			this.labelClientDocument = new System.Windows.Forms.Label();
			this.panelCreateClient = new System.Windows.Forms.Panel();
			this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
			this.labelCarModel = new System.Windows.Forms.Label();
			this.labelCarVersion = new System.Windows.Forms.Label();
			this.comboBoxCarVersion = new System.Windows.Forms.ComboBox();
			this.labelCarYear = new System.Windows.Forms.Label();
			this.comboBoxCarYear = new System.Windows.Forms.ComboBox();
			this.labelCarKm = new System.Windows.Forms.Label();
			this.textBoxCarKm = new System.Windows.Forms.TextBox();
			this.labelTypeWork = new System.Windows.Forms.Label();
			this.comboBoxTypeWork = new System.Windows.Forms.ComboBox();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.labelMechanic = new System.Windows.Forms.Label();
			this.comboBoxMechanic = new System.Windows.Forms.ComboBox();
			this.textBoxFailureDescription = new System.Windows.Forms.TextBox();
			this.labelFailureDescription = new System.Windows.Forms.Label();
			this.labelParts = new System.Windows.Forms.Label();
			this.dataGridViewParts = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonClean = new System.Windows.Forms.Button();
			this.panelCreateClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(800, 25);
			this.panelTop.TabIndex = 0;
			// 
			// buttonAddService
			// 
			this.buttonAddService.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonAddService.FlatAppearance.BorderSize = 0;
			this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddService.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonAddService.Location = new System.Drawing.Point(340, 408);
			this.buttonAddService.Name = "buttonAddService";
			this.buttonAddService.Size = new System.Drawing.Size(146, 39);
			this.buttonAddService.TabIndex = 1;
			this.buttonAddService.Text = "Nuevo Service";
			this.buttonAddService.UseVisualStyleBackColor = true;
			this.buttonAddService.Click += new System.EventHandler(this.buttonCreateService_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonCancel.FlatAppearance.BorderSize = 0;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonCancel.Location = new System.Drawing.Point(644, 408);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(146, 39);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancelar";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// labelClientName
			// 
			this.labelClientName.AutoSize = true;
			this.labelClientName.Location = new System.Drawing.Point(12, 27);
			this.labelClientName.Name = "labelClientName";
			this.labelClientName.Size = new System.Drawing.Size(102, 13);
			this.labelClientName.TabIndex = 4;
			this.labelClientName.Text = "Nombre del Cliente: ";
			// 
			// textBoxClientName
			// 
			this.textBoxClientName.Location = new System.Drawing.Point(15, 43);
			this.textBoxClientName.Name = "textBoxClientName";
			this.textBoxClientName.Size = new System.Drawing.Size(151, 20);
			this.textBoxClientName.TabIndex = 5;
			// 
			// buttonClientSearch
			// 
			this.buttonClientSearch.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonClientSearch.FlatAppearance.BorderSize = 0;
			this.buttonClientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClientSearch.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonClientSearch.Location = new System.Drawing.Point(642, 1);
			this.buttonClientSearch.Name = "buttonClientSearch";
			this.buttonClientSearch.Size = new System.Drawing.Size(146, 39);
			this.buttonClientSearch.TabIndex = 6;
			this.buttonClientSearch.Text = "Buscar";
			this.buttonClientSearch.UseVisualStyleBackColor = true;
			// 
			// buttonCreateClient
			// 
			this.buttonCreateClient.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonCreateClient.FlatAppearance.BorderSize = 0;
			this.buttonCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCreateClient.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonCreateClient.Location = new System.Drawing.Point(642, 38);
			this.buttonCreateClient.Name = "buttonCreateClient";
			this.buttonCreateClient.Size = new System.Drawing.Size(146, 39);
			this.buttonCreateClient.TabIndex = 7;
			this.buttonCreateClient.Text = "Nuevo Cliente";
			this.buttonCreateClient.UseVisualStyleBackColor = true;
			this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
			// 
			// textBoxClientSurname
			// 
			this.textBoxClientSurname.Location = new System.Drawing.Point(195, 43);
			this.textBoxClientSurname.Name = "textBoxClientSurname";
			this.textBoxClientSurname.Size = new System.Drawing.Size(151, 20);
			this.textBoxClientSurname.TabIndex = 9;
			// 
			// labelClientSurname
			// 
			this.labelClientSurname.AutoSize = true;
			this.labelClientSurname.Location = new System.Drawing.Point(192, 27);
			this.labelClientSurname.Name = "labelClientSurname";
			this.labelClientSurname.Size = new System.Drawing.Size(102, 13);
			this.labelClientSurname.TabIndex = 8;
			this.labelClientSurname.Text = "Apellido del Cliente: ";
			// 
			// textBoxClientDocument
			// 
			this.textBoxClientDocument.Location = new System.Drawing.Point(375, 43);
			this.textBoxClientDocument.Name = "textBoxClientDocument";
			this.textBoxClientDocument.Size = new System.Drawing.Size(151, 20);
			this.textBoxClientDocument.TabIndex = 11;
			// 
			// labelClientDocument
			// 
			this.labelClientDocument.AutoSize = true;
			this.labelClientDocument.Location = new System.Drawing.Point(372, 27);
			this.labelClientDocument.Name = "labelClientDocument";
			this.labelClientDocument.Size = new System.Drawing.Size(84, 13);
			this.labelClientDocument.TabIndex = 10;
			this.labelClientDocument.Text = "DNI del Cliente: ";
			// 
			// panelCreateClient
			// 
			this.panelCreateClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCreateClient.Controls.Add(this.buttonClientSearch);
			this.panelCreateClient.Controls.Add(this.textBoxClientDocument);
			this.panelCreateClient.Controls.Add(this.labelClientName);
			this.panelCreateClient.Controls.Add(this.labelClientDocument);
			this.panelCreateClient.Controls.Add(this.textBoxClientName);
			this.panelCreateClient.Controls.Add(this.textBoxClientSurname);
			this.panelCreateClient.Controls.Add(this.buttonCreateClient);
			this.panelCreateClient.Controls.Add(this.labelClientSurname);
			this.panelCreateClient.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCreateClient.Location = new System.Drawing.Point(0, 25);
			this.panelCreateClient.Name = "panelCreateClient";
			this.panelCreateClient.Size = new System.Drawing.Size(800, 81);
			this.panelCreateClient.TabIndex = 12;
			// 
			// comboBoxCarModel
			// 
			this.comboBoxCarModel.FormattingEnabled = true;
			this.comboBoxCarModel.Location = new System.Drawing.Point(16, 142);
			this.comboBoxCarModel.Name = "comboBoxCarModel";
			this.comboBoxCarModel.Size = new System.Drawing.Size(140, 21);
			this.comboBoxCarModel.TabIndex = 13;
			// 
			// labelCarModel
			// 
			this.labelCarModel.AutoSize = true;
			this.labelCarModel.Location = new System.Drawing.Point(13, 126);
			this.labelCarModel.Name = "labelCarModel";
			this.labelCarModel.Size = new System.Drawing.Size(45, 13);
			this.labelCarModel.TabIndex = 14;
			this.labelCarModel.Text = "Modelo:";
			// 
			// labelCarVersion
			// 
			this.labelCarVersion.AutoSize = true;
			this.labelCarVersion.Location = new System.Drawing.Point(193, 126);
			this.labelCarVersion.Name = "labelCarVersion";
			this.labelCarVersion.Size = new System.Drawing.Size(45, 13);
			this.labelCarVersion.TabIndex = 16;
			this.labelCarVersion.Text = "Versión:";
			// 
			// comboBoxCarVersion
			// 
			this.comboBoxCarVersion.FormattingEnabled = true;
			this.comboBoxCarVersion.Location = new System.Drawing.Point(196, 142);
			this.comboBoxCarVersion.Name = "comboBoxCarVersion";
			this.comboBoxCarVersion.Size = new System.Drawing.Size(140, 21);
			this.comboBoxCarVersion.TabIndex = 15;
			// 
			// labelCarYear
			// 
			this.labelCarYear.AutoSize = true;
			this.labelCarYear.Location = new System.Drawing.Point(374, 126);
			this.labelCarYear.Name = "labelCarYear";
			this.labelCarYear.Size = new System.Drawing.Size(29, 13);
			this.labelCarYear.TabIndex = 18;
			this.labelCarYear.Text = "Año:";
			// 
			// comboBoxCarYear
			// 
			this.comboBoxCarYear.FormattingEnabled = true;
			this.comboBoxCarYear.Location = new System.Drawing.Point(377, 142);
			this.comboBoxCarYear.Name = "comboBoxCarYear";
			this.comboBoxCarYear.Size = new System.Drawing.Size(140, 21);
			this.comboBoxCarYear.TabIndex = 17;
			// 
			// labelCarKm
			// 
			this.labelCarKm.AutoSize = true;
			this.labelCarKm.Location = new System.Drawing.Point(557, 127);
			this.labelCarKm.Name = "labelCarKm";
			this.labelCarKm.Size = new System.Drawing.Size(64, 13);
			this.labelCarKm.TabIndex = 19;
			this.labelCarKm.Text = "Kilometraje: ";
			// 
			// textBoxCarKm
			// 
			this.textBoxCarKm.Location = new System.Drawing.Point(560, 143);
			this.textBoxCarKm.Name = "textBoxCarKm";
			this.textBoxCarKm.Size = new System.Drawing.Size(140, 20);
			this.textBoxCarKm.TabIndex = 20;
			// 
			// labelTypeWork
			// 
			this.labelTypeWork.AutoSize = true;
			this.labelTypeWork.Location = new System.Drawing.Point(13, 187);
			this.labelTypeWork.Name = "labelTypeWork";
			this.labelTypeWork.Size = new System.Drawing.Size(85, 13);
			this.labelTypeWork.TabIndex = 22;
			this.labelTypeWork.Text = "Tipo de Trabajo:";
			// 
			// comboBoxTypeWork
			// 
			this.comboBoxTypeWork.FormattingEnabled = true;
			this.comboBoxTypeWork.Location = new System.Drawing.Point(16, 203);
			this.comboBoxTypeWork.Name = "comboBoxTypeWork";
			this.comboBoxTypeWork.Size = new System.Drawing.Size(140, 21);
			this.comboBoxTypeWork.TabIndex = 21;
			// 
			// buttonPrint
			// 
			this.buttonPrint.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonPrint.FlatAppearance.BorderSize = 0;
			this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPrint.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonPrint.Location = new System.Drawing.Point(10, 408);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(146, 39);
			this.buttonPrint.TabIndex = 23;
			this.buttonPrint.Text = "Imprimir Presupuesto";
			this.buttonPrint.UseVisualStyleBackColor = true;
			// 
			// labelMechanic
			// 
			this.labelMechanic.AutoSize = true;
			this.labelMechanic.Location = new System.Drawing.Point(193, 187);
			this.labelMechanic.Name = "labelMechanic";
			this.labelMechanic.Size = new System.Drawing.Size(104, 13);
			this.labelMechanic.TabIndex = 25;
			this.labelMechanic.Text = "Mecanico Asignado:";
			// 
			// comboBoxMechanic
			// 
			this.comboBoxMechanic.FormattingEnabled = true;
			this.comboBoxMechanic.Location = new System.Drawing.Point(196, 203);
			this.comboBoxMechanic.Name = "comboBoxMechanic";
			this.comboBoxMechanic.Size = new System.Drawing.Size(140, 21);
			this.comboBoxMechanic.TabIndex = 24;
			// 
			// textBoxFailureDescription
			// 
			this.textBoxFailureDescription.Location = new System.Drawing.Point(16, 350);
			this.textBoxFailureDescription.Name = "textBoxFailureDescription";
			this.textBoxFailureDescription.Size = new System.Drawing.Size(772, 20);
			this.textBoxFailureDescription.TabIndex = 27;
			// 
			// labelFailureDescription
			// 
			this.labelFailureDescription.AutoSize = true;
			this.labelFailureDescription.Location = new System.Drawing.Point(13, 334);
			this.labelFailureDescription.Name = "labelFailureDescription";
			this.labelFailureDescription.Size = new System.Drawing.Size(103, 13);
			this.labelFailureDescription.TabIndex = 26;
			this.labelFailureDescription.Text = "Descripcion de falla:";
			// 
			// labelParts
			// 
			this.labelParts.AutoSize = true;
			this.labelParts.Location = new System.Drawing.Point(13, 243);
			this.labelParts.Name = "labelParts";
			this.labelParts.Size = new System.Drawing.Size(111, 13);
			this.labelParts.TabIndex = 28;
			this.labelParts.Text = "Insumos y Repuestos:";
			// 
			// dataGridViewParts
			// 
			this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad,
            this.Total});
			this.dataGridViewParts.Location = new System.Drawing.Point(16, 259);
			this.dataGridViewParts.Name = "dataGridViewParts";
			this.dataGridViewParts.Size = new System.Drawing.Size(543, 69);
			this.dataGridViewParts.TabIndex = 29;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// PrecioUnitario
			// 
			this.PrecioUnitario.HeaderText = "Precio Unitario";
			this.PrecioUnitario.Name = "PrecioUnitario";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			// 
			// buttonClean
			// 
			this.buttonClean.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
			this.buttonClean.FlatAppearance.BorderSize = 0;
			this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClean.ForeColor = System.Drawing.Color.White;
			this.buttonClean.Location = new System.Drawing.Point(492, 408);
			this.buttonClean.Name = "buttonClean";
			this.buttonClean.Size = new System.Drawing.Size(146, 39);
			this.buttonClean.TabIndex = 2;
			this.buttonClean.Text = "Limpiar Datos";
			this.buttonClean.UseVisualStyleBackColor = true;
			this.buttonClean.Click += new System.EventHandler(this.cleanButton_Click);
			// 
			// CreateService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridViewParts);
			this.Controls.Add(this.labelParts);
			this.Controls.Add(this.textBoxFailureDescription);
			this.Controls.Add(this.labelFailureDescription);
			this.Controls.Add(this.labelMechanic);
			this.Controls.Add(this.comboBoxMechanic);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.labelTypeWork);
			this.Controls.Add(this.comboBoxTypeWork);
			this.Controls.Add(this.textBoxCarKm);
			this.Controls.Add(this.labelCarKm);
			this.Controls.Add(this.labelCarYear);
			this.Controls.Add(this.comboBoxCarYear);
			this.Controls.Add(this.labelCarVersion);
			this.Controls.Add(this.comboBoxCarVersion);
			this.Controls.Add(this.labelCarModel);
			this.Controls.Add(this.comboBoxCarModel);
			this.Controls.Add(this.panelCreateClient);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonClean);
			this.Controls.Add(this.buttonAddService);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Services";
			this.Load += new System.EventHandler(this.CreateService_Load);
			this.panelCreateClient.ResumeLayout(false);
			this.panelCreateClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Button buttonClientSearch;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.TextBox textBoxClientSurname;
        private System.Windows.Forms.Label labelClientSurname;
        private System.Windows.Forms.TextBox textBoxClientDocument;
        private System.Windows.Forms.Label labelClientDocument;
        private System.Windows.Forms.Panel panelCreateClient;
        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.Label labelCarVersion;
        private System.Windows.Forms.ComboBox comboBoxCarVersion;
        private System.Windows.Forms.Label labelCarYear;
        private System.Windows.Forms.ComboBox comboBoxCarYear;
        private System.Windows.Forms.Label labelCarKm;
        private System.Windows.Forms.TextBox textBoxCarKm;
        private System.Windows.Forms.Label labelTypeWork;
        private System.Windows.Forms.ComboBox comboBoxTypeWork;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelMechanic;
        private System.Windows.Forms.ComboBox comboBoxMechanic;
        private System.Windows.Forms.TextBox textBoxFailureDescription;
        private System.Windows.Forms.Label labelFailureDescription;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

namespace Main.Forms {
	partial class addCliente {
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
            this.txtNombreCalle = new System.Windows.Forms.TextBox();
            this.calleLabel = new System.Windows.Forms.Label();
            this.nameClientLabel = new System.Windows.Forms.Label();
            this.DNIClientLabel = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.surnameClientLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.TipoDNILabel = new System.Windows.Forms.Label();
            this.boxTipoDOC = new System.Windows.Forms.ComboBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.numeracionLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.barrioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreCalle
            // 
            this.txtNombreCalle.Location = new System.Drawing.Point(17, 171);
            this.txtNombreCalle.Name = "txtNombreCalle";
            this.txtNombreCalle.Size = new System.Drawing.Size(151, 20);
            this.txtNombreCalle.TabIndex = 44;
            // 
            // calleLabel
            // 
            this.calleLabel.AutoSize = true;
            this.calleLabel.Location = new System.Drawing.Point(14, 155);
            this.calleLabel.Name = "calleLabel";
            this.calleLabel.Size = new System.Drawing.Size(33, 13);
            this.calleLabel.TabIndex = 43;
            this.calleLabel.Text = "Calle:";
            // 
            // nameClientLabel
            // 
            this.nameClientLabel.AutoSize = true;
            this.nameClientLabel.Location = new System.Drawing.Point(14, 48);
            this.nameClientLabel.Name = "nameClientLabel";
            this.nameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.nameClientLabel.TabIndex = 4;
            this.nameClientLabel.Text = "Nombre del Cliente: ";
            // 
            // DNIClientLabel
            // 
            this.DNIClientLabel.AutoSize = true;
            this.DNIClientLabel.Location = new System.Drawing.Point(14, 102);
            this.DNIClientLabel.Name = "DNIClientLabel";
            this.DNIClientLabel.Size = new System.Drawing.Size(114, 13);
            this.DNIClientLabel.TabIndex = 10;
            this.DNIClientLabel.Text = "DNI/CUIT del Cliente: ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(17, 64);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(151, 20);
            this.txtClientName.TabIndex = 5;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(197, 64);
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(151, 20);
            this.txtClientSurname.TabIndex = 9;
            this.txtClientSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // surnameClientLabel
            // 
            this.surnameClientLabel.AutoSize = true;
            this.surnameClientLabel.Location = new System.Drawing.Point(194, 48);
            this.surnameClientLabel.Name = "surnameClientLabel";
            this.surnameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.surnameClientLabel.TabIndex = 8;
            this.surnameClientLabel.Text = "Apellido del Cliente: ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(187, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 39);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewClient.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewClient.Location = new System.Drawing.Point(35, 281);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(146, 39);
            this.btnNewClient.TabIndex = 33;
            this.btnNewClient.Text = "Nuevo Cliente";
            this.btnNewClient.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(370, 25);
            this.topPanel.TabIndex = 32;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(17, 118);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(151, 20);
            this.txtCUIT.TabIndex = 11;
            // 
            // TipoDNILabel
            // 
            this.TipoDNILabel.AutoSize = true;
            this.TipoDNILabel.Location = new System.Drawing.Point(194, 101);
            this.TipoDNILabel.Name = "TipoDNILabel";
            this.TipoDNILabel.Size = new System.Drawing.Size(104, 13);
            this.TipoDNILabel.TabIndex = 56;
            this.TipoDNILabel.Text = "Tipo de Documento:";
            // 
            // boxTipoDOC
            // 
            this.boxTipoDOC.FormattingEnabled = true;
            this.boxTipoDOC.Location = new System.Drawing.Point(197, 117);
            this.boxTipoDOC.Name = "boxTipoDOC";
            this.boxTipoDOC.Size = new System.Drawing.Size(151, 21);
            this.boxTipoDOC.TabIndex = 58;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(197, 171);
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(64, 20);
            this.txtNumeroCalle.TabIndex = 60;
            // 
            // numeracionLabel
            // 
            this.numeracionLabel.AutoSize = true;
            this.numeracionLabel.Location = new System.Drawing.Point(194, 155);
            this.numeracionLabel.Name = "numeracionLabel";
            this.numeracionLabel.Size = new System.Drawing.Size(67, 13);
            this.numeracionLabel.TabIndex = 59;
            this.numeracionLabel.Text = "Númeración:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(13, 208);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 13);
            this.telefonoLabel.TabIndex = 61;
            this.telefonoLabel.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(17, 224);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(151, 20);
            this.txtTelefono.TabIndex = 62;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 64;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(193, 208);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 63;
            this.emailLabel.Text = "E-mail:";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(284, 171);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(64, 20);
            this.txtBarrio.TabIndex = 68;
            // 
            // barrioLabel
            // 
            this.barrioLabel.AutoSize = true;
            this.barrioLabel.Location = new System.Drawing.Point(281, 155);
            this.barrioLabel.Name = "barrioLabel";
            this.barrioLabel.Size = new System.Drawing.Size(37, 13);
            this.barrioLabel.TabIndex = 67;
            this.barrioLabel.Text = "Barrio:";
            // 
            // addCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 327);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.barrioLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.numeracionLabel);
            this.Controls.Add(this.boxTipoDOC);
            this.Controls.Add(this.TipoDNILabel);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.nameClientLabel);
            this.Controls.Add(this.DNIClientLabel);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtClientSurname);
            this.Controls.Add(this.surnameClientLabel);
            this.Controls.Add(this.txtNombreCalle);
            this.Controls.Add(this.calleLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addCliente";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.TextBox txtNombreCalle;
        private System.Windows.Forms.Label calleLabel;
        private System.Windows.Forms.Label nameClientLabel;
        private System.Windows.Forms.Label DNIClientLabel;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.Label surnameClientLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label TipoDNILabel;
        private System.Windows.Forms.ComboBox boxTipoDOC;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.Label numeracionLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label barrioLabel;
    }
}
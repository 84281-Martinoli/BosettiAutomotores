
namespace Main.Forms {
	partial class Invoices {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.pictureBannerVentas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnVentas);
            this.flowLayoutPanel1.Controls.Add(this.btnPresupuesto);
            this.flowLayoutPanel1.Controls.Add(this.btnHistorial);
            this.flowLayoutPanel1.Controls.Add(this.btnClient);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 560);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = global::Main.Properties.Resources.ButFactura;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Location = new System.Drawing.Point(12, 42);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(230, 160);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.BackgroundImage = global::Main.Properties.Resources.ButPresupuesto;
            this.btnPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresupuesto.Location = new System.Drawing.Point(266, 42);
            this.btnPresupuesto.Margin = new System.Windows.Forms.Padding(12);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(230, 160);
            this.btnPresupuesto.TabIndex = 0;
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackgroundImage = global::Main.Properties.Resources.ButHistorial;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Location = new System.Drawing.Point(520, 42);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(12);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(230, 160);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackgroundImage = global::Main.Properties.Resources.ButClientes;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Location = new System.Drawing.Point(774, 42);
            this.btnClient.Margin = new System.Windows.Forms.Padding(12);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(230, 160);
            this.btnClient.TabIndex = 3;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // pictureBannerVentas
            // 
            this.pictureBannerVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerVentas.Image = global::Main.Properties.Resources.Facturación_Banner;
            this.pictureBannerVentas.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerVentas.Name = "pictureBannerVentas";
            this.pictureBannerVentas.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerVentas.TabIndex = 2;
            this.pictureBannerVentas.TabStop = false;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoices";
            this.Text = "Vendors";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerVentas)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.PictureBox pictureBannerVentas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnClient;
    }
}

namespace Main.Forms
{
    partial class Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStockWindows = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnAlertas = new System.Windows.Forms.Button();
            this.pictureBannerStock = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerStock)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStockWindows);
            this.flowLayoutPanel1.Controls.Add(this.btnInsumos);
            this.flowLayoutPanel1.Controls.Add(this.btnInventario);
            this.flowLayoutPanel1.Controls.Add(this.btnAlertas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 560);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnStockWindows
            // 
            this.btnStockWindows.BackgroundImage = global::Main.Properties.Resources.ButInventarioVer;
            this.btnStockWindows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockWindows.FlatAppearance.BorderSize = 0;
            this.btnStockWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWindows.Location = new System.Drawing.Point(12, 42);
            this.btnStockWindows.Margin = new System.Windows.Forms.Padding(12);
            this.btnStockWindows.Name = "btnStockWindows";
            this.btnStockWindows.Size = new System.Drawing.Size(230, 160);
            this.btnStockWindows.TabIndex = 1;
            this.btnStockWindows.UseVisualStyleBackColor = true;
            this.btnStockWindows.Click += new System.EventHandler(this.btnStockWindows_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.BackgroundImage = global::Main.Properties.Resources.ButGestionarInsumos;
            this.btnInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Location = new System.Drawing.Point(266, 42);
            this.btnInsumos.Margin = new System.Windows.Forms.Padding(12);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(230, 160);
            this.btnInsumos.TabIndex = 0;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackgroundImage = global::Main.Properties.Resources.ButGestionInventario;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Location = new System.Drawing.Point(520, 42);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(230, 160);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnAlertas
            // 
            this.btnAlertas.BackgroundImage = global::Main.Properties.Resources.ButGestorAlerta;
            this.btnAlertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertas.FlatAppearance.BorderSize = 0;
            this.btnAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertas.Location = new System.Drawing.Point(774, 42);
            this.btnAlertas.Margin = new System.Windows.Forms.Padding(12);
            this.btnAlertas.Name = "btnAlertas";
            this.btnAlertas.Size = new System.Drawing.Size(230, 160);
            this.btnAlertas.TabIndex = 3;
            this.btnAlertas.UseVisualStyleBackColor = true;
            this.btnAlertas.Click += new System.EventHandler(this.btnAlertas_Click);
            // 
            // pictureBannerStock
            // 
            this.pictureBannerStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBannerStock.Image = global::Main.Properties.Resources.Stock_Banner;
            this.pictureBannerStock.Location = new System.Drawing.Point(0, 0);
            this.pictureBannerStock.Name = "pictureBannerStock";
            this.pictureBannerStock.Size = new System.Drawing.Size(1020, 150);
            this.pictureBannerStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBannerStock.TabIndex = 0;
            this.pictureBannerStock.TabStop = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBannerStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBannerStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBannerStock;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btnStockWindows;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnAlertas;
    }
}

namespace Main.Forms.InvoiceCRUD
{
    partial class Mostrar_Inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.kmLabel = new System.Windows.Forms.Label();
            this.añoLabel = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.CarLabel = new System.Windows.Forms.Label();
            this.cbModeloAuto = new System.Windows.Forms.ComboBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtIdRepuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieAutomovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAño = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.IDCaja,
            this.Fabricante,
            this.Categoria,
            this.Proveedor,
            this.ModeloAuto,
            this.SerieAutomovil});
            this.dataGridView1.Location = new System.Drawing.Point(9, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 321);
            this.dataGridView1.TabIndex = 53;
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.Location = new System.Drawing.Point(173, 386);
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(140, 20);
            this.txtNombreRepuesto.TabIndex = 3;
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(170, 370);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(47, 13);
            this.kmLabel.TabIndex = 43;
            this.kmLabel.Text = "Nombre:";
            this.kmLabel.Click += new System.EventHandler(this.kmLabel_Click);
            // 
            // añoLabel
            // 
            this.añoLabel.AutoSize = true;
            this.añoLabel.Location = new System.Drawing.Point(644, 368);
            this.añoLabel.Name = "añoLabel";
            this.añoLabel.Size = new System.Drawing.Size(29, 13);
            this.añoLabel.TabIndex = 42;
            this.añoLabel.Text = "Año:";
            // 
            // SLabel
            // 
            this.SLabel.AutoSize = true;
            this.SLabel.Location = new System.Drawing.Point(489, 367);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(34, 13);
            this.SLabel.TabIndex = 40;
            this.SLabel.Text = "Serie:";
            // 
            // cbSerie
            // 
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(492, 383);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(140, 21);
            this.cbSerie.TabIndex = 5;
            // 
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(337, 368);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(45, 13);
            this.CarLabel.TabIndex = 38;
            this.CarLabel.Text = "Modelo:";
            // 
            // cbModeloAuto
            // 
            this.cbModeloAuto.FormattingEnabled = true;
            this.cbModeloAuto.Location = new System.Drawing.Point(340, 384);
            this.cbModeloAuto.Name = "cbModeloAuto";
            this.cbModeloAuto.Size = new System.Drawing.Size(140, 21);
            this.cbModeloAuto.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 25);
            this.topPanel.TabIndex = 32;
            // 
            // txtIdRepuesto
            // 
            this.txtIdRepuesto.Location = new System.Drawing.Point(16, 386);
            this.txtIdRepuesto.Name = "txtIdRepuesto";
            this.txtIdRepuesto.Size = new System.Drawing.Size(140, 20);
            this.txtIdRepuesto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID :";
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(492, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 39);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Filtrar";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.Location = new System.Drawing.Point(644, 410);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(146, 39);
            this.BtnVolver.TabIndex = 35;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
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
            this.PrecioUnitario.Width = 50;
            // 
            // IDCaja
            // 
            this.IDCaja.HeaderText = "Numero Caja";
            this.IDCaja.Name = "IDCaja";
            this.IDCaja.Width = 50;
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // ModeloAuto
            // 
            this.ModeloAuto.HeaderText = "Modelo";
            this.ModeloAuto.Name = "ModeloAuto";
            // 
            // SerieAutomovil
            // 
            this.SerieAutomovil.HeaderText = "Serie";
            this.SerieAutomovil.Name = "SerieAutomovil";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(647, 383);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(140, 20);
            this.txtAño.TabIndex = 56;
            // 
            // Mostrar_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdRepuesto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreRepuesto);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.añoLabel);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.cbSerie);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.cbModeloAuto);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mostrar_Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar_Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label añoLabel;
        private System.Windows.Forms.Label SLabel;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.ComboBox cbModeloAuto;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox txtIdRepuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieAutomovil;
        private System.Windows.Forms.TextBox txtAño;
    }
}
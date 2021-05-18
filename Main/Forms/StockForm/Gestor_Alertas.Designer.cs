
namespace Main.Forms.InvoiceCRUD
{
    partial class Gestor_Alertas
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
            this.dataGridRepuesto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieAutomovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnEstablecerMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRepuesto
            // 
            this.dataGridRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.IDCaja,
            this.Fabricante,
            this.Categoria,
            this.Proveedor,
            this.ModeloAuto,
            this.SerieAutomovil});
            this.dataGridRepuesto.Location = new System.Drawing.Point(12, 31);
            this.dataGridRepuesto.Name = "dataGridRepuesto";
            this.dataGridRepuesto.Size = new System.Drawing.Size(787, 278);
            this.dataGridRepuesto.TabIndex = 126;
            this.dataGridRepuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRepuesto_CellContentClick);
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
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(640, 333);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(146, 39);
            this.btnVolver.TabIndex = 124;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(813, 25);
            this.topPanel.TabIndex = 122;
            // 
            // btnEstablecerMin
            // 
            this.btnEstablecerMin.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnEstablecerMin.Enabled = false;
            this.btnEstablecerMin.FlatAppearance.BorderSize = 0;
            this.btnEstablecerMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstablecerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstablecerMin.ForeColor = System.Drawing.Color.White;
            this.btnEstablecerMin.Location = new System.Drawing.Point(488, 333);
            this.btnEstablecerMin.Name = "btnEstablecerMin";
            this.btnEstablecerMin.Size = new System.Drawing.Size(146, 39);
            this.btnEstablecerMin.TabIndex = 123;
            this.btnEstablecerMin.Text = "Establecer Minimos";
            this.btnEstablecerMin.UseVisualStyleBackColor = true;
            this.btnEstablecerMin.Click += new System.EventHandler(this.btnEstablecerMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "ID :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 343);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 132;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 344);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 20);
            this.txtNombre.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 131;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantMin
            // 
            this.txtCantMin.Location = new System.Drawing.Point(227, 343);
            this.txtCantMin.Name = "txtCantMin";
            this.txtCantMin.Size = new System.Drawing.Size(115, 20);
            this.txtCantMin.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 137;
            this.label3.Text = "Cantidad Minima:";
            // 
            // txtPorcMin
            // 
            this.txtPorcMin.Location = new System.Drawing.Point(348, 343);
            this.txtPorcMin.Name = "txtPorcMin";
            this.txtPorcMin.Size = new System.Drawing.Size(118, 20);
            this.txtPorcMin.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 139;
            this.label4.Text = "Porcentaje Minimo:";
            // 
            // Gestor_Alertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 387);
            this.Controls.Add(this.txtPorcMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridRepuesto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEstablecerMin);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestor_Alertas";
            this.Text = "Gestor_Alertas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieAutomovil;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnEstablecerMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcMin;
        private System.Windows.Forms.Label label4;
    }
}
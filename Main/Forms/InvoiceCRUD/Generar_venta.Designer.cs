
namespace Main.Forms.InvoiceCRUD
{
    partial class Generar_venta
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
            this.gridInsumosRepuestos = new System.Windows.Forms.DataGridView();
            this.Repuestoslabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.ComboBox();
            this.labelSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.ComboBox();
            this.AddClientPanel = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCuil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMetodoPago = new System.Windows.Forms.Label();
            this.txtMetodoPago = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCuil = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumosRepuestos)).BeginInit();
            this.AddClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridInsumosRepuestos
            // 
            this.gridInsumosRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsumosRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad,
            this.Total});
            this.gridInsumosRepuestos.Location = new System.Drawing.Point(18, 258);
            this.gridInsumosRepuestos.Name = "gridInsumosRepuestos";
            this.gridInsumosRepuestos.Size = new System.Drawing.Size(645, 337);
            this.gridInsumosRepuestos.TabIndex = 53;
            // 
            // Repuestoslabel
            // 
            this.Repuestoslabel.AutoSize = true;
            this.Repuestoslabel.Location = new System.Drawing.Point(15, 242);
            this.Repuestoslabel.Name = "Repuestoslabel";
            this.Repuestoslabel.Size = new System.Drawing.Size(111, 13);
            this.Repuestoslabel.TabIndex = 52;
            this.Repuestoslabel.Text = "Insumos y Repuestos:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 624);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(645, 20);
            this.txtDescripcion.TabIndex = 51;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(15, 608);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 50;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Location = new System.Drawing.Point(376, 133);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(29, 13);
            this.labelAño.TabIndex = 42;
            this.labelAño.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.FormattingEnabled = true;
            this.txtAño.Location = new System.Drawing.Point(379, 149);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(140, 21);
            this.txtAño.TabIndex = 41;
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(195, 133);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(34, 13);
            this.labelSerie.TabIndex = 40;
            this.labelSerie.Text = "Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.FormattingEnabled = true;
            this.txtSerie.Location = new System.Drawing.Point(198, 149);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(140, 21);
            this.txtSerie.TabIndex = 39;
            // 
            // txtModelo
            // 
            this.txtModelo.FormattingEnabled = true;
            this.txtModelo.Location = new System.Drawing.Point(18, 149);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(140, 21);
            this.txtModelo.TabIndex = 37;
            // 
            // AddClientPanel
            // 
            this.AddClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddClientPanel.Controls.Add(this.txtCuil);
            this.AddClientPanel.Controls.Add(this.btnBuscar);
            this.AddClientPanel.Controls.Add(this.btnNuevo);
            this.AddClientPanel.Controls.Add(this.labelNombre);
            this.AddClientPanel.Controls.Add(this.labelCuil);
            this.AddClientPanel.Controls.Add(this.txtNombre);
            this.AddClientPanel.Controls.Add(this.txtApellido);
            this.AddClientPanel.Controls.Add(this.labelApellido);
            this.AddClientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClientPanel.Location = new System.Drawing.Point(0, 25);
            this.AddClientPanel.Name = "AddClientPanel";
            this.AddClientPanel.Size = new System.Drawing.Size(730, 92);
            this.AddClientPanel.TabIndex = 36;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 27);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(102, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre del Cliente: ";
            // 
            // labelCuil
            // 
            this.labelCuil.AutoSize = true;
            this.labelCuil.Location = new System.Drawing.Point(375, 27);
            this.labelCuil.Name = "labelCuil";
            this.labelCuil.Size = new System.Drawing.Size(85, 13);
            this.labelCuil.TabIndex = 10;
            this.labelCuil.Text = "CUIL del cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(195, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(151, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(194, 27);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(102, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido del Cliente: ";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(14, 189);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 56;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(17, 205);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(151, 20);
            this.txtCantidad.TabIndex = 57;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(730, 25);
            this.topPanel.TabIndex = 32;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(15, 133);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 38;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMetodoPago
            // 
            this.labelMetodoPago.AutoSize = true;
            this.labelMetodoPago.Location = new System.Drawing.Point(195, 189);
            this.labelMetodoPago.Name = "labelMetodoPago";
            this.labelMetodoPago.Size = new System.Drawing.Size(88, 13);
            this.labelMetodoPago.TabIndex = 61;
            this.labelMetodoPago.Text = "Metodo de pago:";
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.FormattingEnabled = true;
            this.txtMetodoPago.Location = new System.Drawing.Point(198, 205);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(140, 21);
            this.txtMetodoPago.TabIndex = 60;
            // 
            // id
            // 
            this.id.HeaderText = "ID repuesto";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
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
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(378, 42);
            this.txtCuil.Mask = "99-99999999-9";
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(140, 20);
            this.txtCuil.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.TrashCan_24px;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(684, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.BackgroundImage = global::Main.Properties.Resources.Create_24px;
            this.addTableButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addTableButton.FlatAppearance.BorderSize = 0;
            this.addTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTableButton.Location = new System.Drawing.Point(684, 414);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(25, 24);
            this.addTableButton.TabIndex = 54;
            this.addTableButton.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(562, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 39);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(562, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(146, 39);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(517, 652);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 39);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerarFactura.Location = new System.Drawing.Point(16, 652);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(146, 39);
            this.btnGenerarFactura.TabIndex = 62;
            this.btnGenerarFactura.Text = "Generar factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // Generar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 710);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.labelMetodoPago);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.gridInsumosRepuestos);
            this.Controls.Add(this.Repuestoslabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.AddClientPanel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_venta";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumosRepuestos)).EndInit();
            this.AddClientPanel.ResumeLayout(false);
            this.AddClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.DataGridView gridInsumosRepuestos;
        private System.Windows.Forms.Label Repuestoslabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.ComboBox txtAño;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.ComboBox txtSerie;
        private System.Windows.Forms.ComboBox txtModelo;
        private System.Windows.Forms.Panel AddClientPanel;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMetodoPago;
        private System.Windows.Forms.ComboBox txtMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MaskedTextBox txtCuil;
        private System.Windows.Forms.Button btnGenerarFactura;
    }
}
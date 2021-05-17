
namespace Main.Forms.InvoiceCRUD
{
    partial class Generar_presupuesto
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
            this.btnGenerarPresupuesto = new System.Windows.Forms.Button();
            this.labelMetodoPago = new System.Windows.Forms.Label();
            this.boxMetodoPago = new System.Windows.Forms.ComboBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.btnEliminate = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridInsumosRepuestos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repuestoslabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.boxAño = new System.Windows.Forms.ComboBox();
            this.labelSerie = new System.Windows.Forms.Label();
            this.boxSerie = new System.Windows.Forms.ComboBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.boxModelo = new System.Windows.Forms.ComboBox();
            this.AddClientPanel = new System.Windows.Forms.Panel();
            this.txtCuil = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCuil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumosRepuestos)).BeginInit();
            this.AddClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarPresupuesto
            // 
            this.btnGenerarPresupuesto.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnGenerarPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnGenerarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPresupuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerarPresupuesto.Location = new System.Drawing.Point(16, 651);
            this.btnGenerarPresupuesto.Name = "btnGenerarPresupuesto";
            this.btnGenerarPresupuesto.Size = new System.Drawing.Size(146, 39);
            this.btnGenerarPresupuesto.TabIndex = 82;
            this.btnGenerarPresupuesto.Text = "Generar presupuesto";
            this.btnGenerarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // labelMetodoPago
            // 
            this.labelMetodoPago.AutoSize = true;
            this.labelMetodoPago.Location = new System.Drawing.Point(195, 188);
            this.labelMetodoPago.Name = "labelMetodoPago";
            this.labelMetodoPago.Size = new System.Drawing.Size(88, 13);
            this.labelMetodoPago.TabIndex = 81;
            this.labelMetodoPago.Text = "Metodo de pago:";
            // 
            // boxMetodoPago
            // 
            this.boxMetodoPago.FormattingEnabled = true;
            this.boxMetodoPago.Location = new System.Drawing.Point(198, 204);
            this.boxMetodoPago.Name = "boxMetodoPago";
            this.boxMetodoPago.Size = new System.Drawing.Size(140, 21);
            this.boxMetodoPago.TabIndex = 80;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(14, 188);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 78;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // btnEliminate
            // 
            this.btnEliminate.BackgroundImage = global::Main.Properties.Resources.TrashCan_24px;
            this.btnEliminate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminate.FlatAppearance.BorderSize = 0;
            this.btnEliminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminate.Location = new System.Drawing.Point(684, 429);
            this.btnEliminate.Name = "btnEliminate";
            this.btnEliminate.Size = new System.Drawing.Size(25, 24);
            this.btnEliminate.TabIndex = 77;
            this.btnEliminate.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(17, 204);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(151, 20);
            this.txtCantidad.TabIndex = 79;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Main.Properties.Resources.Create_24px;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(684, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 24);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.gridInsumosRepuestos.Location = new System.Drawing.Point(18, 257);
            this.gridInsumosRepuestos.Name = "gridInsumosRepuestos";
            this.gridInsumosRepuestos.Size = new System.Drawing.Size(645, 337);
            this.gridInsumosRepuestos.TabIndex = 75;
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
            // Repuestoslabel
            // 
            this.Repuestoslabel.AutoSize = true;
            this.Repuestoslabel.Location = new System.Drawing.Point(15, 241);
            this.Repuestoslabel.Name = "Repuestoslabel";
            this.Repuestoslabel.Size = new System.Drawing.Size(111, 13);
            this.Repuestoslabel.TabIndex = 74;
            this.Repuestoslabel.Text = "Insumos y Repuestos:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 623);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(645, 20);
            this.txtDescripcion.TabIndex = 73;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(15, 607);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 72;
            this.labelDescripcion.Text = "Descripcion:";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Location = new System.Drawing.Point(376, 132);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(29, 13);
            this.labelAño.TabIndex = 71;
            this.labelAño.Text = "Año:";
            // 
            // boxAño
            // 
            this.boxAño.FormattingEnabled = true;
            this.boxAño.Location = new System.Drawing.Point(379, 148);
            this.boxAño.Name = "boxAño";
            this.boxAño.Size = new System.Drawing.Size(140, 21);
            this.boxAño.TabIndex = 70;
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(195, 132);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(34, 13);
            this.labelSerie.TabIndex = 69;
            this.labelSerie.Text = "Serie:";
            // 
            // boxSerie
            // 
            this.boxSerie.FormattingEnabled = true;
            this.boxSerie.Location = new System.Drawing.Point(198, 148);
            this.boxSerie.Name = "boxSerie";
            this.boxSerie.Size = new System.Drawing.Size(140, 21);
            this.boxSerie.TabIndex = 68;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(15, 132);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 67;
            this.labelModelo.Text = "Modelo:";
            // 
            // boxModelo
            // 
            this.boxModelo.FormattingEnabled = true;
            this.boxModelo.Location = new System.Drawing.Point(18, 148);
            this.boxModelo.Name = "boxModelo";
            this.boxModelo.Size = new System.Drawing.Size(140, 21);
            this.boxModelo.TabIndex = 66;
            // 
            // AddClientPanel
            // 
            this.AddClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddClientPanel.Controls.Add(this.txtCuil);
            this.AddClientPanel.Controls.Add(this.btnBuscar);
            this.AddClientPanel.Controls.Add(this.btnNuevoCliente);
            this.AddClientPanel.Controls.Add(this.labelNombre);
            this.AddClientPanel.Controls.Add(this.labelCuil);
            this.AddClientPanel.Controls.Add(this.txtNombre);
            this.AddClientPanel.Controls.Add(this.txtApellido);
            this.AddClientPanel.Controls.Add(this.labelApellido);
            this.AddClientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClientPanel.Location = new System.Drawing.Point(0, 25);
            this.AddClientPanel.Name = "AddClientPanel";
            this.AddClientPanel.Size = new System.Drawing.Size(736, 92);
            this.AddClientPanel.TabIndex = 65;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(378, 42);
            this.txtCuil.Mask = "99-99999999-9";
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(140, 20);
            this.txtCuil.TabIndex = 14;
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
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoCliente.Location = new System.Drawing.Point(562, 43);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(146, 39);
            this.btnNuevoCliente.TabIndex = 13;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
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
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(517, 651);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 39);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.CancelButton_Click_2);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(736, 25);
            this.topPanel.TabIndex = 63;
            // 
            // Generar_presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 713);
            this.Controls.Add(this.btnGenerarPresupuesto);
            this.Controls.Add(this.labelMetodoPago);
            this.Controls.Add(this.boxMetodoPago);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.btnEliminate);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridInsumosRepuestos);
            this.Controls.Add(this.Repuestoslabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.boxAño);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.boxSerie);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.boxModelo);
            this.Controls.Add(this.AddClientPanel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_presupuesto";
            this.Text = "Generar_presupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumosRepuestos)).EndInit();
            this.AddClientPanel.ResumeLayout(false);
            this.AddClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarPresupuesto;
        private System.Windows.Forms.Label labelMetodoPago;
        private System.Windows.Forms.ComboBox boxMetodoPago;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button btnEliminate;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridInsumosRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label Repuestoslabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.ComboBox boxAño;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.ComboBox boxSerie;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox boxModelo;
        private System.Windows.Forms.Panel AddClientPanel;
        private System.Windows.Forms.MaskedTextBox txtCuil;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel topPanel;
    }
}
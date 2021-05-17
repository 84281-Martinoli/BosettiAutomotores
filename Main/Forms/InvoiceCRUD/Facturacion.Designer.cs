
namespace Main.Forms.InvoiceCRUD
{
    partial class Facturacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Repuestoslabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.añoLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AddClientPanel = new System.Windows.Forms.Panel();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameClientLabel = new System.Windows.Forms.Label();
            this.DNIClientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addClientbutton = new System.Windows.Forms.Button();
            this.surnameClientLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.CarLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Main.Properties.Resources.TrashCan_24px;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(726, 426);
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
            this.addTableButton.Location = new System.Drawing.Point(726, 396);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(25, 24);
            this.addTableButton.TabIndex = 54;
            this.addTableButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.PrecioUnitario,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(18, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 337);
            this.dataGridView1.TabIndex = 53;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 614);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(772, 20);
            this.textBox5.TabIndex = 51;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descripcion:";
            // 
            // printbutton
            // 
            this.printbutton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.printbutton.FlatAppearance.BorderSize = 0;
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.printbutton.Location = new System.Drawing.Point(13, 650);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(146, 39);
            this.printbutton.TabIndex = 47;
            this.printbutton.Text = "Imprimir Presupuesto";
            this.printbutton.UseVisualStyleBackColor = true;
            // 
            // añoLabel
            // 
            this.añoLabel.AutoSize = true;
            this.añoLabel.Location = new System.Drawing.Point(376, 133);
            this.añoLabel.Name = "añoLabel";
            this.añoLabel.Size = new System.Drawing.Size(29, 13);
            this.añoLabel.TabIndex = 42;
            this.añoLabel.Text = "Año:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(379, 149);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 41;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(195, 133);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 40;
            this.versionLabel.Text = "Versión:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(198, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // AddClientPanel
            // 
            this.AddClientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddClientPanel.Controls.Add(this.BuscarButton);
            this.AddClientPanel.Controls.Add(this.textBox3);
            this.AddClientPanel.Controls.Add(this.nameClientLabel);
            this.AddClientPanel.Controls.Add(this.DNIClientLabel);
            this.AddClientPanel.Controls.Add(this.textBox1);
            this.AddClientPanel.Controls.Add(this.textBox2);
            this.AddClientPanel.Controls.Add(this.addClientbutton);
            this.AddClientPanel.Controls.Add(this.surnameClientLabel);
            this.AddClientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClientPanel.Location = new System.Drawing.Point(0, 25);
            this.AddClientPanel.Name = "AddClientPanel";
            this.AddClientPanel.Size = new System.Drawing.Size(800, 92);
            this.AddClientPanel.TabIndex = 36;
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BuscarButton.Location = new System.Drawing.Point(642, 1);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(146, 39);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(375, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 11;
            // 
            // nameClientLabel
            // 
            this.nameClientLabel.AutoSize = true;
            this.nameClientLabel.Location = new System.Drawing.Point(12, 27);
            this.nameClientLabel.Name = "nameClientLabel";
            this.nameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.nameClientLabel.TabIndex = 4;
            this.nameClientLabel.Text = "Nombre del Cliente: ";
            // 
            // DNIClientLabel
            // 
            this.DNIClientLabel.AutoSize = true;
            this.DNIClientLabel.Location = new System.Drawing.Point(372, 27);
            this.DNIClientLabel.Name = "DNIClientLabel";
            this.DNIClientLabel.Size = new System.Drawing.Size(85, 13);
            this.DNIClientLabel.TabIndex = 10;
            this.DNIClientLabel.Text = "CUIL del cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 9;
            // 
            // addClientbutton
            // 
            this.addClientbutton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.addClientbutton.FlatAppearance.BorderSize = 0;
            this.addClientbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.addClientbutton.Location = new System.Drawing.Point(642, 38);
            this.addClientbutton.Name = "addClientbutton";
            this.addClientbutton.Size = new System.Drawing.Size(146, 39);
            this.addClientbutton.TabIndex = 7;
            this.addClientbutton.Text = "Nuevo Cliente";
            this.addClientbutton.UseVisualStyleBackColor = true;
            // 
            // surnameClientLabel
            // 
            this.surnameClientLabel.AutoSize = true;
            this.surnameClientLabel.Location = new System.Drawing.Point(192, 27);
            this.surnameClientLabel.Name = "surnameClientLabel";
            this.surnameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.surnameClientLabel.TabIndex = 8;
            this.surnameClientLabel.Text = "Apellido del Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cantidad:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(17, 205);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 20);
            this.textBox7.TabIndex = 57;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(647, 650);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(146, 39);
            this.CancelButton.TabIndex = 35;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(495, 650);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(146, 39);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Limpiar Datos";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // addServiceButton
            // 
            this.addServiceButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.addServiceButton.FlatAppearance.BorderSize = 0;
            this.addServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addServiceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addServiceButton.Location = new System.Drawing.Point(343, 650);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(146, 39);
            this.addServiceButton.TabIndex = 33;
            this.addServiceButton.Text = "Nuevo Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
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
            // CarLabel
            // 
            this.CarLabel.AutoSize = true;
            this.CarLabel.Location = new System.Drawing.Point(15, 133);
            this.CarLabel.Name = "CarLabel";
            this.CarLabel.Size = new System.Drawing.Size(45, 13);
            this.CarLabel.TabIndex = 38;
            this.CarLabel.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Modelo:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(195, 204);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 21);
            this.comboBox4.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Metodo de pago:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(376, 205);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 21);
            this.comboBox5.TabIndex = 60;
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
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Repuestoslabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.añoLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CarLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddClientPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddClientPanel.ResumeLayout(false);
            this.AddClientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Repuestoslabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Label añoLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel AddClientPanel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nameClientLabel;
        private System.Windows.Forms.Label DNIClientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addClientbutton;
        private System.Windows.Forms.Label surnameClientLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label CarLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}
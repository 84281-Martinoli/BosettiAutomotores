
namespace Main.Forms.InvoiceCRUD
{
    partial class Historial_ventas
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
            this.AddClientPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameClientLabel = new System.Windows.Forms.Label();
            this.DNIClientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.surnameClientLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.printbutton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.addClientbutton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.AddClientPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.AddClientPanel.Size = new System.Drawing.Size(800, 81);
            this.AddClientPanel.TabIndex = 36;
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
            this.DNIClientLabel.Size = new System.Drawing.Size(84, 13);
            this.DNIClientLabel.TabIndex = 10;
            this.DNIClientLabel.Text = "DNI del Cliente: ";
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
            // surnameClientLabel
            // 
            this.surnameClientLabel.AutoSize = true;
            this.surnameClientLabel.Location = new System.Drawing.Point(192, 27);
            this.surnameClientLabel.Name = "surnameClientLabel";
            this.surnameClientLabel.Size = new System.Drawing.Size(102, 13);
            this.surnameClientLabel.TabIndex = 8;
            this.surnameClientLabel.Text = "Apellido del Cliente: ";
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
            // printbutton
            // 
            this.printbutton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.printbutton.FlatAppearance.BorderSize = 0;
            this.printbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.printbutton.Location = new System.Drawing.Point(10, 410);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(146, 39);
            this.printbutton.TabIndex = 47;
            this.printbutton.Text = "Imprimir Presupuesto";
            this.printbutton.UseVisualStyleBackColor = true;
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
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(644, 410);
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
            this.clearButton.Location = new System.Drawing.Point(492, 410);
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
            this.addServiceButton.Location = new System.Drawing.Point(340, 410);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(146, 39);
            this.addServiceButton.TabIndex = 33;
            this.addServiceButton.Text = "Nuevo Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            // 
            // Historial_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.AddClientPanel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial_ventas";
            this.Text = "Historial_ventas";
            this.AddClientPanel.ResumeLayout(false);
            this.AddClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printbutton;
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
    }
}
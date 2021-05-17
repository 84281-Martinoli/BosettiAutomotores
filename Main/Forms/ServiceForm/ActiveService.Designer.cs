
namespace Main.Forms.ServiceForm
{
    partial class ActiveService
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GridShowService = new System.Windows.Forms.DataGridView();
            this.cuil_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KmCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridShowService)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(765, 25);
            this.topPanel.TabIndex = 32;
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::Main.Properties.Resources.ButGenericoForm;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClose.Location = new System.Drawing.Point(607, 392);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(146, 39);
            this.BtnClose.TabIndex = 35;
            this.BtnClose.Text = "Cerrar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GridShowService
            // 
            this.GridShowService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridShowService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuil_cliente,
            this.Patente,
            this.TipoService,
            this.fechaInicio,
            this.LastService,
            this.KmCar,
            this.Empleado});
            this.GridShowService.Location = new System.Drawing.Point(12, 31);
            this.GridShowService.Name = "GridShowService";
            this.GridShowService.Size = new System.Drawing.Size(743, 355);
            this.GridShowService.TabIndex = 36;
            this.GridShowService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cuil_cliente
            // 
            this.cuil_cliente.HeaderText = "Cliente";
            this.cuil_cliente.Name = "cuil_cliente";
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // TipoService
            // 
            this.TipoService.HeaderText = "Trabajo a realizar";
            this.TipoService.Name = "TipoService";
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha de Inicio";
            this.fechaInicio.Name = "fechaInicio";
            // 
            // LastService
            // 
            this.LastService.HeaderText = "Ultimo Service Realizado";
            this.LastService.Name = "LastService";
            // 
            // KmCar
            // 
            this.KmCar.HeaderText = "Kilometraje";
            this.KmCar.Name = "KmCar";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado Receptor";
            this.Empleado.Name = "Empleado";
            // 
            // ActiveService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.GridShowService);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActiveService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveService";
            ((System.ComponentModel.ISupportInitialize)(this.GridShowService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView GridShowService;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoService;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastService;
        private System.Windows.Forms.DataGridViewTextBoxColumn KmCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
    }
}
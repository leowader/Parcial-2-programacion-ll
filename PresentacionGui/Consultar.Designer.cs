namespace PresentacionGui
{
    partial class Consultar
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
            this.GrilaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.RbName = new System.Windows.Forms.RadioButton();
            this.RbCategoria = new System.Windows.Forms.RadioButton();
            this.RbFecha = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrilaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrilaProductos
            // 
            this.GrilaProductos.AllowUserToAddRows = false;
            this.GrilaProductos.AllowUserToDeleteRows = false;
            this.GrilaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrilaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.GrilaProductos.Location = new System.Drawing.Point(47, 112);
            this.GrilaProductos.Name = "GrilaProductos";
            this.GrilaProductos.ReadOnly = true;
            this.GrilaProductos.RowHeadersVisible = false;
            this.GrilaProductos.Size = new System.Drawing.Size(496, 274);
            this.GrilaProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "referencia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categoria";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "fecha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(47, 78);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(184, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(468, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RbName
            // 
            this.RbName.AutoSize = true;
            this.RbName.Location = new System.Drawing.Point(237, 81);
            this.RbName.Name = "RbName";
            this.RbName.Size = new System.Drawing.Size(62, 17);
            this.RbName.TabIndex = 3;
            this.RbName.TabStop = true;
            this.RbName.Text = "Nombre";
            this.RbName.UseVisualStyleBackColor = true;
            // 
            // RbCategoria
            // 
            this.RbCategoria.AutoSize = true;
            this.RbCategoria.Location = new System.Drawing.Point(316, 81);
            this.RbCategoria.Name = "RbCategoria";
            this.RbCategoria.Size = new System.Drawing.Size(70, 17);
            this.RbCategoria.TabIndex = 4;
            this.RbCategoria.TabStop = true;
            this.RbCategoria.Text = "Categoria";
            this.RbCategoria.UseVisualStyleBackColor = true;
            // 
            // RbFecha
            // 
            this.RbFecha.AutoSize = true;
            this.RbFecha.Location = new System.Drawing.Point(407, 81);
            this.RbFecha.Name = "RbFecha";
            this.RbFecha.Size = new System.Drawing.Size(55, 17);
            this.RbFecha.TabIndex = 5;
            this.RbFecha.TabStop = true;
            this.RbFecha.Text = "Fecha";
            this.RbFecha.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(468, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCTOS";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.RbFecha);
            this.Controls.Add(this.RbCategoria);
            this.Controls.Add(this.RbName);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.GrilaProductos);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrilaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrilaProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton RbName;
        private System.Windows.Forms.RadioButton RbCategoria;
        private System.Windows.Forms.RadioButton RbFecha;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}
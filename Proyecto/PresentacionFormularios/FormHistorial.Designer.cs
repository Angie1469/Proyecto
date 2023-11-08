
namespace Proyecto
{
    partial class FormHistorial
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
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVer = new System.Windows.Forms.Button();
            this.labelPedido = new System.Windows.Forms.Label();
            this.ComboPedidos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridViewPedido.Location = new System.Drawing.Point(48, 156);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.Size = new System.Drawing.Size(680, 212);
            this.dataGridViewPedido.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonVer);
            this.panel1.Controls.Add(this.dataGridViewPedido);
            this.panel1.Controls.Add(this.labelPedido);
            this.panel1.Controls.Add(this.ComboPedidos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 420);
            this.panel1.TabIndex = 41;
            // 
            // buttonVer
            // 
            this.buttonVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVer.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVer.Location = new System.Drawing.Point(609, 40);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(119, 39);
            this.buttonVer.TabIndex = 43;
            this.buttonVer.Text = "Ver";
            this.buttonVer.UseVisualStyleBackColor = false;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedido.ForeColor = System.Drawing.Color.Black;
            this.labelPedido.Location = new System.Drawing.Point(619, 103);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(71, 22);
            this.labelPedido.TabIndex = 35;
            this.labelPedido.Text = "Pedido";
            // 
            // ComboPedidos
            // 
            this.ComboPedidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboPedidos.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPedidos.FormattingEnabled = true;
            this.ComboPedidos.Location = new System.Drawing.Point(48, 49);
            this.ComboPedidos.Name = "ComboPedidos";
            this.ComboPedidos.Size = new System.Drawing.Size(264, 30);
            this.ComboPedidos.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Seleccione el pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Historial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "# Factura";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "cantidad";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha Creación";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección de entrega";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total a pagar";
            this.Column3.Name = "Column3";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.ComboBox ComboPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
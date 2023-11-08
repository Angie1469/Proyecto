
namespace Proyecto
{
    partial class GestionarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDireccion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textMostrarCantidad = new System.Windows.Forms.TextBox();
            this.buttonAñadirM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IngresoCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCrearPedido = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccione una dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pedido";
            // 
            // comboBoxDireccion
            // 
            this.comboBoxDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDireccion.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDireccion.FormattingEnabled = true;
            this.comboBoxDireccion.Location = new System.Drawing.Point(70, 85);
            this.comboBoxDireccion.Name = "comboBoxDireccion";
            this.comboBoxDireccion.Size = new System.Drawing.Size(264, 28);
            this.comboBoxDireccion.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textMostrarCantidad);
            this.panel1.Controls.Add(this.buttonAñadirM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IngresoCantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxMedicamento);
            this.panel1.Location = new System.Drawing.Point(70, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 120);
            this.panel1.TabIndex = 27;
            // 
            // textMostrarCantidad
            // 
            this.textMostrarCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textMostrarCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMostrarCantidad.Location = new System.Drawing.Point(506, 15);
            this.textMostrarCantidad.Name = "textMostrarCantidad";
            this.textMostrarCantidad.Size = new System.Drawing.Size(247, 26);
            this.textMostrarCantidad.TabIndex = 35;
            this.textMostrarCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAñadirM
            // 
            this.buttonAñadirM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAñadirM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadirM.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirM.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAñadirM.Location = new System.Drawing.Point(605, 68);
            this.buttonAñadirM.Name = "buttonAñadirM";
            this.buttonAñadirM.Size = new System.Drawing.Size(148, 39);
            this.buttonAñadirM.TabIndex = 31;
            this.buttonAñadirM.Text = "Añadir";
            this.buttonAñadirM.UseVisualStyleBackColor = false;
            this.buttonAñadirM.Click += new System.EventHandler(this.buttonAñadirM_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(385, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ingrese la cantidad";
            // 
            // IngresoCantidad
            // 
            this.IngresoCantidad.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoCantidad.Location = new System.Drawing.Point(321, 57);
            this.IngresoCantidad.Name = "IngresoCantidad";
            this.IngresoCantidad.Size = new System.Drawing.Size(47, 39);
            this.IngresoCantidad.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(308, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cantidad disponible :";
            // 
            // comboBoxMedicamento
            // 
            this.comboBoxMedicamento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMedicamento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedicamento.FormattingEnabled = true;
            this.comboBoxMedicamento.Location = new System.Drawing.Point(22, 15);
            this.comboBoxMedicamento.Name = "comboBoxMedicamento";
            this.comboBoxMedicamento.Size = new System.Drawing.Size(264, 27);
            this.comboBoxMedicamento.TabIndex = 29;
            this.comboBoxMedicamento.SelectedValueChanged += new System.EventHandler(this.comboBoxMedicamento_SelectedValueChanged);
            // 
            // dataGridViewPedido
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewPedido.Location = new System.Drawing.Point(70, 276);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.Size = new System.Drawing.Size(779, 163);
            this.dataGridViewPedido.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Generico";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor Total";
            this.Column5.Name = "Column5";
            // 
            // buttonCrearPedido
            // 
            this.buttonCrearPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCrearPedido.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearPedido.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCrearPedido.Location = new System.Drawing.Point(162, 456);
            this.buttonCrearPedido.Name = "buttonCrearPedido";
            this.buttonCrearPedido.Size = new System.Drawing.Size(147, 45);
            this.buttonCrearPedido.TabIndex = 29;
            this.buttonCrearPedido.Text = "Aceptar";
            this.buttonCrearPedido.UseVisualStyleBackColor = false;
            this.buttonCrearPedido.Click += new System.EventHandler(this.buttonCrearPedido_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(597, 456);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(147, 45);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEliminar.Location = new System.Drawing.Point(379, 456);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(147, 45);
            this.buttonEliminar.TabIndex = 31;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // GestionarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrearPedido);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown IngresoCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMedicamento;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCrearPedido;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAñadirM;
        private System.Windows.Forms.TextBox textMostrarCantidad;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
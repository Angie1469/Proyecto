
namespace Proyecto
{
    partial class FormLoteIngreso
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
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaVencimiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadir.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAñadir.Location = new System.Drawing.Point(571, 107);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(156, 39);
            this.buttonAñadir.TabIndex = 55;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = false;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cantidad:";
            // 
            // textBoxFechaVencimiento
            // 
            this.textBoxFechaVencimiento.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaVencimiento.Location = new System.Drawing.Point(176, 62);
            this.textBoxFechaVencimiento.Name = "textBoxFechaVencimiento";
            this.textBoxFechaVencimiento.Size = new System.Drawing.Size(180, 30);
            this.textBoxFechaVencimiento.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha Vencimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Medicamento:";
            // 
            // comboBoxMedicamento
            // 
            this.comboBoxMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMedicamento.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedicamento.FormattingEnabled = true;
            this.comboBoxMedicamento.Location = new System.Drawing.Point(176, 12);
            this.comboBoxMedicamento.Name = "comboBoxMedicamento";
            this.comboBoxMedicamento.Size = new System.Drawing.Size(180, 30);
            this.comboBoxMedicamento.TabIndex = 56;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(176, 113);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(180, 30);
            this.textBoxCantidad.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(426, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 58;
            this.label5.Text = "Proveedor:";
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxProveedor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(547, 12);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(180, 30);
            this.comboBoxProveedor.TabIndex = 59;
            // 
            // FormLoteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(755, 171);
            this.Controls.Add(this.comboBoxProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.comboBoxMedicamento);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoteIngreso";
            this.Text = "Lote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedicamento;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
    }
}
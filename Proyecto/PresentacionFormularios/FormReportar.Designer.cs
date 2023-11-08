
namespace Proyecto
{
    partial class FormReportarMedicamento
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
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonDañado = new System.Windows.Forms.RadioButton();
            this.radioButtonVencido = new System.Windows.Forms.RadioButton();
            this.buttonReportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxLoteVencido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDañoslote = new System.Windows.Forms.ComboBox();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewDatos.Location = new System.Drawing.Point(64, 303);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(444, 138);
            this.dataGridViewDatos.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Lote";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            // 
            // radioButtonDañado
            // 
            this.radioButtonDañado.AutoSize = true;
            this.radioButtonDañado.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDañado.Location = new System.Drawing.Point(418, 14);
            this.radioButtonDañado.Name = "radioButtonDañado";
            this.radioButtonDañado.Size = new System.Drawing.Size(190, 23);
            this.radioButtonDañado.TabIndex = 48;
            this.radioButtonDañado.TabStop = true;
            this.radioButtonDañado.Text = "Medicamento Dañado";
            this.radioButtonDañado.UseVisualStyleBackColor = true;
            this.radioButtonDañado.CheckedChanged += new System.EventHandler(this.radioButtonDañado_CheckedChanged);
            // 
            // radioButtonVencido
            // 
            this.radioButtonVencido.AutoSize = true;
            this.radioButtonVencido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVencido.Location = new System.Drawing.Point(22, 14);
            this.radioButtonVencido.Name = "radioButtonVencido";
            this.radioButtonVencido.Size = new System.Drawing.Size(191, 23);
            this.radioButtonVencido.TabIndex = 47;
            this.radioButtonVencido.TabStop = true;
            this.radioButtonVencido.Text = "Medicamento Vencido";
            this.radioButtonVencido.UseVisualStyleBackColor = true;
            this.radioButtonVencido.CheckedChanged += new System.EventHandler(this.radioButtonVencido_CheckedChanged);
            // 
            // buttonReportar
            // 
            this.buttonReportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReportar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReportar.Location = new System.Drawing.Point(349, 460);
            this.buttonReportar.Name = "buttonReportar";
            this.buttonReportar.Size = new System.Drawing.Size(230, 45);
            this.buttonReportar.TabIndex = 46;
            this.buttonReportar.Text = "Reportar";
            this.buttonReportar.UseVisualStyleBackColor = false;
            this.buttonReportar.Click += new System.EventHandler(this.buttonReportar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Reportar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxLoteVencido
            // 
            this.comboBoxLoteVencido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxLoteVencido.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoteVencido.FormattingEnabled = true;
            this.comboBoxLoteVencido.Location = new System.Drawing.Point(59, 82);
            this.comboBoxLoteVencido.Name = "comboBoxLoteVencido";
            this.comboBoxLoteVencido.Size = new System.Drawing.Size(270, 30);
            this.comboBoxLoteVencido.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Selecione el Lote vencido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(454, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Selecione el Lote dañado";
            // 
            // comboBoxDañoslote
            // 
            this.comboBoxDañoslote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDañoslote.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDañoslote.FormattingEnabled = true;
            this.comboBoxDañoslote.Location = new System.Drawing.Point(458, 82);
            this.comboBoxDañoslote.Name = "comboBoxDañoslote";
            this.comboBoxDañoslote.Size = new System.Drawing.Size(270, 30);
            this.comboBoxDañoslote.TabIndex = 62;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadir.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAñadir.Location = new System.Drawing.Point(22, 129);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(132, 40);
            this.buttonAñadir.TabIndex = 64;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = false;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.textBoxCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonAñadir);
            this.panel1.Controls.Add(this.radioButtonVencido);
            this.panel1.Controls.Add(this.comboBoxDañoslote);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonDañado);
            this.panel1.Controls.Add(this.comboBoxLoteVencido);
            this.panel1.Location = new System.Drawing.Point(64, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 185);
            this.panel1.TabIndex = 65;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(549, 128);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(179, 26);
            this.textBoxCantidad.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(454, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cantidad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 338);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 103);
            this.textBox1.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(539, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Motivo del daño:";
            // 
            // FormReportarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.buttonReportar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportarMedicamento";
            this.Text = "Form15";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.RadioButton radioButtonDañado;
        private System.Windows.Forms.RadioButton radioButtonVencido;
        private System.Windows.Forms.Button buttonReportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLoteVencido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDañoslote;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

namespace Proyecto
{
    partial class FormIngresarDatos
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLoteMedicamento = new System.Windows.Forms.Panel();
            this.dataGridViewMeidcamentoLote = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeidcamentoLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(284, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 23);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lote";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(98, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 23);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Medicamento";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegistar.Location = new System.Drawing.Point(352, 448);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(230, 45);
            this.buttonRegistar.TabIndex = 39;
            this.buttonRegistar.Text = "Registrar";
            this.buttonRegistar.UseVisualStyleBackColor = false;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ingresar";
            // 
            // panelLoteMedicamento
            // 
            this.panelLoteMedicamento.Location = new System.Drawing.Point(74, 129);
            this.panelLoteMedicamento.Name = "panelLoteMedicamento";
            this.panelLoteMedicamento.Size = new System.Drawing.Size(755, 171);
            this.panelLoteMedicamento.TabIndex = 42;
            // 
            // dataGridViewMeidcamentoLote
            // 
            this.dataGridViewMeidcamentoLote.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMeidcamentoLote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMeidcamentoLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeidcamentoLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewMeidcamentoLote.Location = new System.Drawing.Point(74, 317);
            this.dataGridViewMeidcamentoLote.Name = "dataGridViewMeidcamentoLote";
            this.dataGridViewMeidcamentoLote.Size = new System.Drawing.Size(755, 115);
            this.dataGridViewMeidcamentoLote.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.linea;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormIngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.dataGridViewMeidcamentoLote);
            this.Controls.Add(this.panelLoteMedicamento);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresarDatos";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.FormIngresarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeidcamentoLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLoteMedicamento;
        public System.Windows.Forms.DataGridView dataGridViewMeidcamentoLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.Button buttonRegistar;
    }
}
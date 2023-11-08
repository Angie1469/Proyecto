
namespace Proyecto
{
    partial class FormDireccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewDireccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAñadirDireccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(140, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese nueva dirrección:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(144, 162);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(638, 30);
            this.textBoxDireccion.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Añadir Dirección";
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
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGuardar.Location = new System.Drawing.Point(552, 400);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(230, 45);
            this.buttonGuardar.TabIndex = 39;
            this.buttonGuardar.Text = "Guardar ";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewDireccion
            // 
            this.dataGridViewDireccion.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewDireccion.Location = new System.Drawing.Point(144, 324);
            this.dataGridViewDireccion.Name = "dataGridViewDireccion";
            this.dataGridViewDireccion.Size = new System.Drawing.Size(338, 121);
            this.dataGridViewDireccion.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dirrección";
            this.Column1.Name = "Column1";
            // 
            // buttonAñadirDireccion
            // 
            this.buttonAñadirDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAñadirDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadirDireccion.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAñadirDireccion.Location = new System.Drawing.Point(344, 239);
            this.buttonAñadirDireccion.Name = "buttonAñadirDireccion";
            this.buttonAñadirDireccion.Size = new System.Drawing.Size(230, 45);
            this.buttonAñadirDireccion.TabIndex = 39;
            this.buttonAñadirDireccion.Text = "Añadir";
            this.buttonAñadirDireccion.UseVisualStyleBackColor = false;
            this.buttonAñadirDireccion.Click += new System.EventHandler(this.buttonAñadirDireccion_Click_1);
            // 
            // FormDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.dataGridViewDireccion);
            this.Controls.Add(this.buttonAñadirDireccion);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonAñadirDireccion;
    }
}
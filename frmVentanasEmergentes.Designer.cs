namespace pryResumenLabo
{
    partial class frmVentanasEmergentes
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnFondo = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(665, 42);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(503, 42);
            this.btnRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(112, 35);
            this.btnRuta.TabIndex = 10;
            this.btnRuta.Text = "Ruta txt";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(341, 42);
            this.btnCarpeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(112, 35);
            this.btnCarpeta.TabIndex = 9;
            this.btnCarpeta.Text = "Carpeta Nueva";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Test";
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(179, 42);
            this.btnTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(112, 35);
            this.btnTexto.TabIndex = 7;
            this.btnTexto.Text = "Texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnFondo
            // 
            this.btnFondo.Location = new System.Drawing.Point(17, 42);
            this.btnFondo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(112, 35);
            this.btnFondo.TabIndex = 6;
            this.btnFondo.Text = "Color Fondo";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmVentanasEmergentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.btnFondo);
            this.Name = "frmVentanasEmergentes";
            this.Text = "frmVentanasEmergentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
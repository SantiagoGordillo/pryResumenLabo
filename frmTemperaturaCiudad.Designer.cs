namespace pryResumenLabo
{
    partial class frmTemperaturaCiudad
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
            this.cbLocalidades = new System.Windows.Forms.ComboBox();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Maxima = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLocalidades
            // 
            this.cbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidades.FormattingEnabled = true;
            this.cbLocalidades.Location = new System.Drawing.Point(202, 42);
            this.cbLocalidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLocalidades.Name = "cbLocalidades";
            this.cbLocalidades.Size = new System.Drawing.Size(148, 28);
            this.cbLocalidades.TabIndex = 19;
            // 
            // txtMaxima
            // 
            this.txtMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxima.Enabled = false;
            this.txtMaxima.Location = new System.Drawing.Point(202, 192);
            this.txtMaxima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(148, 26);
            this.txtMaxima.TabIndex = 18;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(202, 90);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(148, 26);
            this.dtpFecha.TabIndex = 17;
            // 
            // txtMinima
            // 
            this.txtMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinima.Enabled = false;
            this.txtMinima.Location = new System.Drawing.Point(202, 142);
            this.txtMinima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(148, 26);
            this.txtMinima.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(153, 244);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Maxima
            // 
            this.Maxima.AutoSize = true;
            this.Maxima.Location = new System.Drawing.Point(65, 195);
            this.Maxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maxima.Name = "Maxima";
            this.Maxima.Size = new System.Drawing.Size(63, 20);
            this.Maxima.TabIndex = 14;
            this.Maxima.Text = "Maxima";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Location = new System.Drawing.Point(65, 145);
            this.lblMinima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(59, 20);
            this.lblMinima.TabIndex = 13;
            this.lblMinima.Text = "Minima";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(65, 95);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(65, 45);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 11;
            this.lblLocalidad.Text = "Localidad";
            // 
            // frmTemperaturaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 314);
            this.Controls.Add(this.cbLocalidades);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Maxima);
            this.Controls.Add(this.lblMinima);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLocalidad);
            this.Name = "frmTemperaturaCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar en una base de datos";
            this.Load += new System.EventHandler(this.frmTemperaturaCiudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocalidades;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Maxima;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLocalidad;
    }
}
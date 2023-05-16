namespace pryResumenLabo
{
    partial class frmAgregarAlumno
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "BARRIO";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(405, 386);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(112, 35);
            this.btnGrabar.TabIndex = 22;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cbBarrio
            // 
            this.cbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(181, 312);
            this.cbBarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(336, 28);
            this.cbBarrio.TabIndex = 21;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(181, 248);
            this.txtFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(336, 26);
            this.txtFoto.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 114);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 26);
            this.txtNombre.TabIndex = 19;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(181, 35);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(148, 26);
            this.txtDni.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "FOTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "SEXO";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(391, 181);
            this.rbM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(129, 24);
            this.rbM.TabIndex = 15;
            this.rbM.Text = "MASCULINO";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Checked = true;
            this.rbF.Location = new System.Drawing.Point(181, 181);
            this.rbF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(118, 24);
            this.rbF.TabIndex = 14;
            this.rbF.TabStop = true;
            this.rbF.Text = "FEMENINO";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "DNI";
            // 
            // frmAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cbBarrio);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarAlumno";
            this.Text = "Agregar Alumno";
            this.Load += new System.EventHandler(this.frmAgregarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cbBarrio;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
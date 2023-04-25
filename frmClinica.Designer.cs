namespace pryResumenLabo
{
    partial class frmClinica
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
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.grillaMedicos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbMedicos = new System.Windows.Forms.ListBox();
            this.lblGrilla = new System.Windows.Forms.Label();
            this.lblListbox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(17, 52);
            this.cbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(231, 28);
            this.cbEspecialidad.TabIndex = 3;
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Location = new System.Drawing.Point(13, 27);
            this.lblEspecialidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(235, 20);
            this.lblEspecialidades.TabIndex = 2;
            this.lblEspecialidades.Text = "SELECCIONE ESPECIALIDAD";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(274, 36);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(134, 36);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // grillaMedicos
            // 
            this.grillaMedicos.AllowUserToAddRows = false;
            this.grillaMedicos.AllowUserToDeleteRows = false;
            this.grillaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMedicos.Location = new System.Drawing.Point(17, 90);
            this.grillaMedicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaMedicos.Name = "grillaMedicos";
            this.grillaMedicos.ReadOnly = true;
            this.grillaMedicos.RowHeadersWidth = 62;
            this.grillaMedicos.Size = new System.Drawing.Size(391, 324);
            this.grillaMedicos.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(555, 36);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(134, 36);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbMedicos
            // 
            this.lbMedicos.FormattingEnabled = true;
            this.lbMedicos.ItemHeight = 20;
            this.lbMedicos.Location = new System.Drawing.Point(436, 90);
            this.lbMedicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMedicos.Name = "lbMedicos";
            this.lbMedicos.Size = new System.Drawing.Size(346, 324);
            this.lbMedicos.TabIndex = 7;
            // 
            // lblGrilla
            // 
            this.lblGrilla.AutoSize = true;
            this.lblGrilla.Location = new System.Drawing.Point(183, 444);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(45, 20);
            this.lblGrilla.TabIndex = 8;
            this.lblGrilla.Text = "Grilla";
            // 
            // lblListbox
            // 
            this.lblListbox.AutoSize = true;
            this.lblListbox.Location = new System.Drawing.Point(578, 444);
            this.lblListbox.Name = "lblListbox";
            this.lblListbox.Size = new System.Drawing.Size(59, 20);
            this.lblListbox.TabIndex = 9;
            this.lblListbox.Text = "Listbox";
            // 
            // frmClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.lblListbox);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.lbMedicos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grillaMedicos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.lblEspecialidades);
            this.Name = "frmClinica";
            this.Text = "Clinica";
            this.Load += new System.EventHandler(this.frmClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView grillaMedicos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lbMedicos;
        private System.Windows.Forms.Label lblGrilla;
        private System.Windows.Forms.Label lblListbox;
    }
}
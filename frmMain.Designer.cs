namespace pryResumenLabo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClinica = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTreeView = new System.Windows.Forms.TextBox();
            this.btnTreeView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClinica
            // 
            this.btnClinica.Location = new System.Drawing.Point(60, 54);
            this.btnClinica.Name = "btnClinica";
            this.btnClinica.Size = new System.Drawing.Size(107, 41);
            this.btnClinica.TabIndex = 0;
            this.btnClinica.Text = "Clinica";
            this.btnClinica.UseVisualStyleBackColor = true;
            this.btnClinica.Click += new System.EventHandler(this.btnClinica_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Cargar una grilla y un listbox";
            // 
            // txtTreeView
            // 
            this.txtTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTreeView.Enabled = false;
            this.txtTreeView.Location = new System.Drawing.Point(256, 22);
            this.txtTreeView.Name = "txtTreeView";
            this.txtTreeView.Size = new System.Drawing.Size(130, 26);
            this.txtTreeView.TabIndex = 3;
            this.txtTreeView.Text = "Uso del TreeView";
            // 
            // btnTreeView
            // 
            this.btnTreeView.Location = new System.Drawing.Point(268, 54);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(107, 41);
            this.btnTreeView.TabIndex = 2;
            this.btnTreeView.Text = "TreeView";
            this.btnTreeView.UseVisualStyleBackColor = true;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 434);
            this.Controls.Add(this.txtTreeView);
            this.Controls.Add(this.btnTreeView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClinica);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClinica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTreeView;
        private System.Windows.Forms.Button btnTreeView;
    }
}


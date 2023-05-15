namespace pryResumenLabo
{
    partial class frmArchivo
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
            this.lvFrutas = new System.Windows.Forms.ListView();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnFrutas = new System.Windows.Forms.Button();
            this.txtFrutas = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvFrutas
            // 
            this.lvFrutas.HideSelection = false;
            this.lvFrutas.Location = new System.Drawing.Point(54, 210);
            this.lvFrutas.Name = "lvFrutas";
            this.lvFrutas.Size = new System.Drawing.Size(396, 175);
            this.lvFrutas.TabIndex = 10;
            this.lvFrutas.UseCompatibleStateImageBehavior = false;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(54, 156);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(112, 35);
            this.btnLeer.TabIndex = 9;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnFrutas
            // 
            this.btnFrutas.Location = new System.Drawing.Point(54, 99);
            this.btnFrutas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFrutas.Name = "btnFrutas";
            this.btnFrutas.Size = new System.Drawing.Size(112, 35);
            this.btnFrutas.TabIndex = 8;
            this.btnFrutas.Text = "Frutas";
            this.btnFrutas.UseVisualStyleBackColor = true;
            this.btnFrutas.Click += new System.EventHandler(this.btnFrutas_Click);
            // 
            // txtFrutas
            // 
            this.txtFrutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrutas.Location = new System.Drawing.Point(245, 47);
            this.txtFrutas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrutas.Name = "txtFrutas";
            this.txtFrutas.Size = new System.Drawing.Size(170, 26);
            this.txtFrutas.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(54, 42);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(112, 35);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 413);
            this.Controls.Add(this.lvFrutas);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnFrutas);
            this.Controls.Add(this.txtFrutas);
            this.Controls.Add(this.btnGrabar);
            this.Name = "frmArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear, modificar y leer archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFrutas;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnFrutas;
        private System.Windows.Forms.TextBox txtFrutas;
        private System.Windows.Forms.Button btnGrabar;
    }
}
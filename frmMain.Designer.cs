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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnDato = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnFrutas = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClinica
            // 
            this.btnClinica.Location = new System.Drawing.Point(60, 54);
            this.btnClinica.Name = "btnClinica";
            this.btnClinica.Size = new System.Drawing.Size(107, 41);
            this.btnClinica.TabIndex = 0;
            this.btnClinica.Text = "Abrir";
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
            this.txtTreeView.Location = new System.Drawing.Point(245, 22);
            this.txtTreeView.Name = "txtTreeView";
            this.txtTreeView.Size = new System.Drawing.Size(130, 26);
            this.txtTreeView.TabIndex = 3;
            this.txtTreeView.Text = "Uso del TreeView";
            // 
            // btnTreeView
            // 
            this.btnTreeView.Location = new System.Drawing.Point(257, 54);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Size = new System.Drawing.Size(107, 41);
            this.btnTreeView.TabIndex = 2;
            this.btnTreeView.Text = "Abrir";
            this.btnTreeView.UseVisualStyleBackColor = true;
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(406, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Crear, modificar y leer archivo";
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(460, 54);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(107, 41);
            this.btnArchivo.TabIndex = 4;
            this.btnArchivo.Text = "Abrir";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(651, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Buscar un dato en una base de datos";
            // 
            // btnDato
            // 
            this.btnDato.Location = new System.Drawing.Point(734, 54);
            this.btnDato.Name = "btnDato";
            this.btnDato.Size = new System.Drawing.Size(107, 41);
            this.btnDato.TabIndex = 6;
            this.btnDato.Text = "Abrir";
            this.btnDato.UseVisualStyleBackColor = true;
            this.btnDato.Click += new System.EventHandler(this.btnDato_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(57, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Proyecto frutas";
            // 
            // btnFrutas
            // 
            this.btnFrutas.Location = new System.Drawing.Point(60, 157);
            this.btnFrutas.Name = "btnFrutas";
            this.btnFrutas.Size = new System.Drawing.Size(107, 41);
            this.btnFrutas.TabIndex = 8;
            this.btnFrutas.Text = "Abrir";
            this.btnFrutas.UseVisualStyleBackColor = true;
            this.btnFrutas.Click += new System.EventHandler(this.btnFrutas_Click);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(249, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 26);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Proyecto Mundo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(452, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(122, 26);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Guardar archivo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 239);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnFrutas);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnDato);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.txtTreeView);
            this.Controls.Add(this.btnTreeView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClinica);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClinica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTreeView;
        private System.Windows.Forms.Button btnTreeView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnDato;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnFrutas;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
    }
}


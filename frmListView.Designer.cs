namespace pryResumenLabo
{
    partial class frmListView
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(702, 422);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(112, 35);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lv
            // 
            this.lv.CheckBoxes = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(36, 42);
            this.lv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(778, 339);
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.List;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 495);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lv);
            this.Name = "frmListView";
            this.Text = "Uso del ListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView lv;
    }
}
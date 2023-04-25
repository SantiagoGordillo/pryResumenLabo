namespace pryResumenLabo
{
    partial class frmTreeView
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
            this.tvDatos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvDatos
            // 
            this.tvDatos.Location = new System.Drawing.Point(13, 14);
            this.tvDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvDatos.Name = "tvDatos";
            this.tvDatos.Size = new System.Drawing.Size(328, 259);
            this.tvDatos.TabIndex = 1;
            this.tvDatos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDatos_NodeMouseClick);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 294);
            this.Controls.Add(this.tvDatos);
            this.Name = "frmTreeView";
            this.Text = "Uso del TreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDatos;
    }
}
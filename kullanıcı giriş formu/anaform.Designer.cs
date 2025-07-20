namespace kullanıcı_giriş_formu
{
    partial class Anaform
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
            this.lblselamla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblselamla
            // 
            this.lblselamla.AutoSize = true;
            this.lblselamla.Location = new System.Drawing.Point(47, 32);
            this.lblselamla.Name = "lblselamla";
            this.lblselamla.Size = new System.Drawing.Size(52, 13);
            this.lblselamla.TabIndex = 0;
            this.lblselamla.Text = "lblselamla";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 301);
            this.Controls.Add(this.lblselamla);
            this.Name = "Anaform";
            this.Text = "Anaform";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselamla;
    }
}
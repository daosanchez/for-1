namespace for_1
{
    partial class Form1
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(32, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.Location = new System.Drawing.Point(181, 28);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(138, 238);
            this.lbAd.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(32, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 56);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 297);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox lbAd;
        private System.Windows.Forms.Button btnEkle;
    }
}


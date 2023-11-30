namespace ders1button_label
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnIsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(222, 98);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(51, 20);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "label1";
            // 
            // btnIsim
            // 
            this.btnIsim.Location = new System.Drawing.Point(193, 169);
            this.btnIsim.Name = "btnIsim";
            this.btnIsim.Size = new System.Drawing.Size(122, 29);
            this.btnIsim.TabIndex = 1;
            this.btnIsim.Text = "burton";
            this.btnIsim.UseVisualStyleBackColor = true;
            this.btnIsim.Click += new System.EventHandler(this.btnIsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 286);
            this.Controls.Add(this.btnIsim);
            this.Controls.Add(this.lblIsim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnIsim;
    }
}


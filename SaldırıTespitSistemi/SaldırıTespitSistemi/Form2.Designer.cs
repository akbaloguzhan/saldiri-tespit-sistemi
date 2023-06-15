namespace SaldırıTespitSistemi
{
    partial class Form2
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
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSaldiriOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Location = new System.Drawing.Point(699, 367);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 40);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeri.Location = new System.Drawing.Point(12, 367);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(89, 40);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 339);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSaldiriOlustur
            // 
            this.btnSaldiriOlustur.Location = new System.Drawing.Point(333, 367);
            this.btnSaldiriOlustur.Name = "btnSaldiriOlustur";
            this.btnSaldiriOlustur.Size = new System.Drawing.Size(113, 40);
            this.btnSaldiriOlustur.TabIndex = 3;
            this.btnSaldiriOlustur.Text = "Saldırı Oluştur";
            this.btnSaldiriOlustur.UseVisualStyleBackColor = true;
            this.btnSaldiriOlustur.Click += new System.EventHandler(this.btnSaldiriOlustur_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnSaldiriOlustur);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnCikis);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldırı Tespit Sistemi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.Windows.Forms.Button btnSaldiriOlustur;
    }
}
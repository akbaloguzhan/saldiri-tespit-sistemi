namespace SaldırıTespitSistemi
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
            this.cbVeriSeti = new System.Windows.Forms.ComboBox();
            this.cbAlgoritma = new System.Windows.Forms.ComboBox();
            this.btnModelEgit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVeriSeti
            // 
            this.cbVeriSeti.FormattingEnabled = true;
            this.cbVeriSeti.Location = new System.Drawing.Point(120, 55);
            this.cbVeriSeti.Name = "cbVeriSeti";
            this.cbVeriSeti.Size = new System.Drawing.Size(121, 21);
            this.cbVeriSeti.TabIndex = 1;
            this.cbVeriSeti.SelectedIndexChanged += new System.EventHandler(this.cbVeriSeti_SelectedIndexChanged);
            // 
            // cbAlgoritma
            // 
            this.cbAlgoritma.FormattingEnabled = true;
            this.cbAlgoritma.Location = new System.Drawing.Point(403, 55);
            this.cbAlgoritma.Name = "cbAlgoritma";
            this.cbAlgoritma.Size = new System.Drawing.Size(121, 21);
            this.cbAlgoritma.TabIndex = 2;
            this.cbAlgoritma.SelectedIndexChanged += new System.EventHandler(this.cbAlgoritma_SelectedIndexChanged);
            // 
            // btnModelEgit
            // 
            this.btnModelEgit.Location = new System.Drawing.Point(219, 146);
            this.btnModelEgit.Name = "btnModelEgit";
            this.btnModelEgit.Size = new System.Drawing.Size(142, 66);
            this.btnModelEgit.TabIndex = 3;
            this.btnModelEgit.Text = "Seçilen Modeli Kullan";
            this.btnModelEgit.UseVisualStyleBackColor = true;
            this.btnModelEgit.Click += new System.EventHandler(this.btnModelEgit_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(495, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Veri Seti : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(315, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algoritma : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModelEgit);
            this.Controls.Add(this.cbAlgoritma);
            this.Controls.Add(this.cbVeriSeti);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saldırı Tespit Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVeriSeti;
        private System.Windows.Forms.ComboBox cbAlgoritma;
        private System.Windows.Forms.Button btnModelEgit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


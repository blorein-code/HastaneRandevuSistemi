namespace Proje_Hastane
{
    partial class HastaGirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcNoLabel = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.uyeOlButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // tcNoLabel
            // 
            this.tcNoLabel.Location = new System.Drawing.Point(161, 77);
            this.tcNoLabel.Name = "tcNoLabel";
            this.tcNoLabel.Size = new System.Drawing.Size(156, 20);
            this.tcNoLabel.TabIndex = 2;
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(161, 122);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(156, 20);
            this.sifreLabel.TabIndex = 3;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Location = new System.Drawing.Point(161, 168);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(75, 23);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyeOlButton
            // 
            this.uyeOlButton.Location = new System.Drawing.Point(242, 168);
            this.uyeOlButton.Name = "uyeOlButton";
            this.uyeOlButton.Size = new System.Drawing.Size(75, 23);
            this.uyeOlButton.TabIndex = 6;
            this.uyeOlButton.Text = "Üye Ol";
            this.uyeOlButton.UseVisualStyleBackColor = true;
            this.uyeOlButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(132, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // HastaGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(436, 233);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uyeOlButton);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.tcNoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaGirisForm";
            this.Text = "HastaForm";
            this.Load += new System.EventHandler(this.HastaGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcNoLabel;
        private System.Windows.Forms.TextBox sifreLabel;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Button uyeOlButton;
        private System.Windows.Forms.Label label3;
    }
}
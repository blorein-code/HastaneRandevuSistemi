namespace Proje_Hastane
{
    partial class SekreterGirisForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.sifreLabel = new System.Windows.Forms.TextBox();
            this.tcNoLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // girisYapButton
            // 
            this.girisYapButton.Location = new System.Drawing.Point(186, 223);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(75, 23);
            this.girisYapButton.TabIndex = 19;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(143, 175);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(156, 20);
            this.sifreLabel.TabIndex = 18;
            // 
            // tcNoLabel
            // 
            this.tcNoLabel.Location = new System.Drawing.Point(143, 130);
            this.tcNoLabel.Name = "tcNoLabel";
            this.tcNoLabel.Size = new System.Drawing.Size(156, 20);
            this.tcNoLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC Kimlik No:";
            // 
            // SekreterGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(432, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.tcNoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SekreterGirisForm";
            this.Text = "Sekreter Giriş ";
            this.Load += new System.EventHandler(this.SekreterGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.TextBox sifreLabel;
        private System.Windows.Forms.TextBox tcNoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace Proje_Hastane
{
    partial class DoktorBilgiDuzenle
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
            this.bilgiGuncelleButton = new System.Windows.Forms.Button();
            this.telefonLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bransCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilgiGuncelleButton
            // 
            this.bilgiGuncelleButton.Location = new System.Drawing.Point(99, 264);
            this.bilgiGuncelleButton.Name = "bilgiGuncelleButton";
            this.bilgiGuncelleButton.Size = new System.Drawing.Size(170, 23);
            this.bilgiGuncelleButton.TabIndex = 49;
            this.bilgiGuncelleButton.Text = "Bilgi Güncelle";
            this.bilgiGuncelleButton.UseVisualStyleBackColor = true;
            this.bilgiGuncelleButton.Click += new System.EventHandler(this.bilgiGuncelleButton_Click);
            // 
            // telefonLabel
            // 
            this.telefonLabel.Location = new System.Drawing.Point(133, 210);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(125, 20);
            this.telefonLabel.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Telefon:";
            // 
            // soyadLabel
            // 
            this.soyadLabel.Location = new System.Drawing.Point(133, 71);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(124, 20);
            this.soyadLabel.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Soyad:";
            // 
            // AdLabel
            // 
            this.AdLabel.Location = new System.Drawing.Point(133, 36);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(125, 20);
            this.AdLabel.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ad:";
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(133, 175);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(125, 20);
            this.sifreLabel.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Şifre:";
            // 
            // tcLabel
            // 
            this.tcLabel.Location = new System.Drawing.Point(133, 105);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(125, 20);
            this.tcLabel.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "TC Kimlik No:";
            // 
            // bransCombo
            // 
            this.bransCombo.FormattingEnabled = true;
            this.bransCombo.Location = new System.Drawing.Point(133, 140);
            this.bransCombo.Name = "bransCombo";
            this.bransCombo.Size = new System.Drawing.Size(125, 21);
            this.bransCombo.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Branş:";
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(345, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bransCombo);
            this.Controls.Add(this.bilgiGuncelleButton);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.label1);
            this.Name = "DoktorBilgiDuzenle";
            this.Text = "DoktorBilgiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bilgiGuncelleButton;
        private System.Windows.Forms.TextBox telefonLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soyadLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bransCombo;
        private System.Windows.Forms.Label label6;
    }
}
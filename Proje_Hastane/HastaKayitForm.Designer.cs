namespace Proje_Hastane
{
    partial class HastaKayitForm
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
            this.tcLabel = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaAdLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kayitOlButton = new System.Windows.Forms.Button();
            this.cinsiyetCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // tcLabel
            // 
            this.tcLabel.Location = new System.Drawing.Point(291, 72);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(111, 20);
            this.tcLabel.TabIndex = 4;
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(291, 112);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(111, 20);
            this.sifreLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cinsiyet:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // telefonLabel
            // 
            this.telefonLabel.Location = new System.Drawing.Point(89, 154);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(100, 20);
            this.telefonLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefon:";
            // 
            // soyadLabel
            // 
            this.soyadLabel.Location = new System.Drawing.Point(89, 115);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(100, 20);
            this.soyadLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Soyadı:";
            // 
            // hastaAdLabel
            // 
            this.hastaAdLabel.Location = new System.Drawing.Point(89, 72);
            this.hastaAdLabel.Name = "hastaAdLabel";
            this.hastaAdLabel.Size = new System.Drawing.Size(100, 20);
            this.hastaAdLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(144, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hasta Kayıt Formu";
            // 
            // kayitOlButton
            // 
            this.kayitOlButton.Location = new System.Drawing.Point(193, 205);
            this.kayitOlButton.Name = "kayitOlButton";
            this.kayitOlButton.Size = new System.Drawing.Size(75, 23);
            this.kayitOlButton.TabIndex = 20;
            this.kayitOlButton.Text = "Kayıt Ol";
            this.kayitOlButton.UseVisualStyleBackColor = true;
            this.kayitOlButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cinsiyetCombo
            // 
            this.cinsiyetCombo.FormattingEnabled = true;
            this.cinsiyetCombo.Location = new System.Drawing.Point(291, 153);
            this.cinsiyetCombo.Name = "cinsiyetCombo";
            this.cinsiyetCombo.Size = new System.Drawing.Size(111, 21);
            this.cinsiyetCombo.TabIndex = 21;
            // 
            // HastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(437, 240);
            this.Controls.Add(this.cinsiyetCombo);
            this.Controls.Add(this.kayitOlButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaAdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tcLabel);
            this.Controls.Add(this.label1);
            this.Name = "HastaKayitForm";
            this.Text = "UyelikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcLabel;
        private System.Windows.Forms.TextBox sifreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox soyadLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hastaAdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kayitOlButton;
        private System.Windows.Forms.ComboBox cinsiyetCombo;
    }
}
namespace Proje_Hastane
{
    partial class DoktorDetayForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sikayetText = new System.Windows.Forms.RichTextBox();
            this.bilgiDuzenleButon = new System.Windows.Forms.Button();
            this.duyuruButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tcNoLabel = new System.Windows.Forms.Label();
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adSoyadLabel);
            this.groupBox1.Controls.Add(this.tcNoLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sikayetText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(242, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 326);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şikayet:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cikisButon);
            this.groupBox4.Controls.Add(this.duyuruButon);
            this.groupBox4.Controls.Add(this.bilgiDuzenleButon);
            this.groupBox4.Location = new System.Drawing.Point(12, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 78);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // sikayetText
            // 
            this.sikayetText.Location = new System.Drawing.Point(0, 19);
            this.sikayetText.Name = "sikayetText";
            this.sikayetText.Size = new System.Drawing.Size(224, 107);
            this.sikayetText.TabIndex = 2;
            this.sikayetText.Text = "";
            // 
            // bilgiDuzenleButon
            // 
            this.bilgiDuzenleButon.Location = new System.Drawing.Point(6, 19);
            this.bilgiDuzenleButon.Name = "bilgiDuzenleButon";
            this.bilgiDuzenleButon.Size = new System.Drawing.Size(100, 23);
            this.bilgiDuzenleButon.TabIndex = 0;
            this.bilgiDuzenleButon.Text = "Bilgi Düzenle";
            this.bilgiDuzenleButon.UseVisualStyleBackColor = true;
            this.bilgiDuzenleButon.Click += new System.EventHandler(this.bilgiDuzenleButon_Click);
            // 
            // duyuruButon
            // 
            this.duyuruButon.Location = new System.Drawing.Point(112, 20);
            this.duyuruButon.Name = "duyuruButon";
            this.duyuruButon.Size = new System.Drawing.Size(106, 23);
            this.duyuruButon.TabIndex = 1;
            this.duyuruButon.Text = "Duyurular";
            this.duyuruButon.UseVisualStyleBackColor = true;
            this.duyuruButon.Click += new System.EventHandler(this.duyuruButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.Location = new System.Drawing.Point(6, 49);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(212, 23);
            this.cikisButon.TabIndex = 2;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad:";
            // 
            // tcNoLabel
            // 
            this.tcNoLabel.AutoSize = true;
            this.tcNoLabel.Location = new System.Drawing.Point(78, 30);
            this.tcNoLabel.Name = "tcNoLabel";
            this.tcNoLabel.Size = new System.Drawing.Size(73, 13);
            this.tcNoLabel.TabIndex = 2;
            this.tcNoLabel.Text = "00000000000";
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Location = new System.Drawing.Point(78, 59);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(46, 13);
            this.adSoyadLabel.TabIndex = 3;
            this.adSoyadLabel.Text = "Null Null";
            // 
            // DoktorDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 347);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DoktorDetayForm";
            this.Text = "DoktorDetayForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.Label tcNoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox sikayetText;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button duyuruButon;
        private System.Windows.Forms.Button bilgiDuzenleButon;
    }
}
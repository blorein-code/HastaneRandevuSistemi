namespace Proje_Hastane
{
    partial class DoktorPanelForm
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
            this.adText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bransCombo = new System.Windows.Forms.ComboBox();
            this.tcText = new System.Windows.Forms.MaskedTextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekleButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.guncelleButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(57, 22);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(156, 20);
            this.adText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad:";
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(57, 52);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(156, 20);
            this.soyadText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Şifre:";
            // 
            // bransCombo
            // 
            this.bransCombo.FormattingEnabled = true;
            this.bransCombo.Location = new System.Drawing.Point(57, 80);
            this.bransCombo.Name = "bransCombo";
            this.bransCombo.Size = new System.Drawing.Size(156, 21);
            this.bransCombo.TabIndex = 3;
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(57, 108);
            this.tcText.Mask = "00000000000";
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(156, 20);
            this.tcText.TabIndex = 4;
            this.tcText.ValidatingType = typeof(int);
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(57, 140);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(156, 20);
            this.sifreText.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 196);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(57, 166);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(75, 23);
            this.ekleButon.TabIndex = 29;
            this.ekleButon.Text = "Ekle";
            this.ekleButon.UseVisualStyleBackColor = true;
            this.ekleButon.Click += new System.EventHandler(this.ekleButon_Click);
            // 
            // silButon
            // 
            this.silButon.Location = new System.Drawing.Point(138, 166);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(75, 23);
            this.silButon.TabIndex = 30;
            this.silButon.Text = "Sil";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // guncelleButon
            // 
            this.guncelleButon.Location = new System.Drawing.Point(57, 195);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(156, 23);
            this.guncelleButon.TabIndex = 31;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = true;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // DoktorPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(804, 230);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.bransCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.label1);
            this.Name = "DoktorPanelForm";
            this.Text = "DoktorPanelForm";
            this.Load += new System.EventHandler(this.DoktorPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bransCombo;
        private System.Windows.Forms.MaskedTextBox tcText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button guncelleButon;
    }
}
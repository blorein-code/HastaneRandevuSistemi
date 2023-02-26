namespace Proje_Hastane
{
    partial class BransPanelForm
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
            this.guncelleButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.ekleButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bransAdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bransIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelleButon
            // 
            this.guncelleButon.Location = new System.Drawing.Point(65, 105);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(134, 23);
            this.guncelleButon.TabIndex = 45;
            this.guncelleButon.Text = "Güncelle";
            this.guncelleButon.UseVisualStyleBackColor = true;
            // 
            // silButon
            // 
            this.silButon.Location = new System.Drawing.Point(137, 76);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(62, 23);
            this.silButon.TabIndex = 44;
            this.silButon.Text = "Sil";
            this.silButon.UseVisualStyleBackColor = true;
            // 
            // ekleButon
            // 
            this.ekleButon.Location = new System.Drawing.Point(65, 76);
            this.ekleButon.Name = "ekleButon";
            this.ekleButon.Size = new System.Drawing.Size(66, 23);
            this.ekleButon.TabIndex = 43;
            this.ekleButon.Text = "Ekle";
            this.ekleButon.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 115);
            this.dataGridView1.TabIndex = 42;
            // 
            // bransAdText
            // 
            this.bransAdText.Location = new System.Drawing.Point(61, 43);
            this.bransAdText.Name = "bransAdText";
            this.bransAdText.Size = new System.Drawing.Size(147, 20);
            this.bransAdText.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Branş Ad:";
            // 
            // bransIdText
            // 
            this.bransIdText.Location = new System.Drawing.Point(61, 13);
            this.bransIdText.Name = "bransIdText";
            this.bransIdText.Size = new System.Drawing.Size(147, 20);
            this.bransIdText.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Branş Id:";
            // 
            // BransPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 135);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.ekleButon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bransAdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bransIdText);
            this.Controls.Add(this.label1);
            this.Name = "BransPanelForm";
            this.Text = "BransPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guncelleButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button ekleButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bransAdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bransIdText;
        private System.Windows.Forms.Label label1;
    }
}
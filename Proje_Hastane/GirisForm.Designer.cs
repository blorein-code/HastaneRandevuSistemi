namespace Proje_Hastane
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.hastaGirisButon = new System.Windows.Forms.Button();
            this.doktorGirisButon = new System.Windows.Forms.Button();
            this.sekreterGirisButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaGirisButon
            // 
            this.hastaGirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastaGirisButon.BackgroundImage")));
            this.hastaGirisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastaGirisButon.Location = new System.Drawing.Point(13, 151);
            this.hastaGirisButon.Name = "hastaGirisButon";
            this.hastaGirisButon.Size = new System.Drawing.Size(124, 87);
            this.hastaGirisButon.TabIndex = 4;
            this.hastaGirisButon.UseVisualStyleBackColor = true;
            this.hastaGirisButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // doktorGirisButon
            // 
            this.doktorGirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorGirisButon.BackgroundImage")));
            this.doktorGirisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doktorGirisButon.Location = new System.Drawing.Point(179, 151);
            this.doktorGirisButon.Name = "doktorGirisButon";
            this.doktorGirisButon.Size = new System.Drawing.Size(127, 87);
            this.doktorGirisButon.TabIndex = 5;
            this.doktorGirisButon.UseVisualStyleBackColor = true;
            this.doktorGirisButon.Click += new System.EventHandler(this.button2_Click);
            // 
            // sekreterGirisButon
            // 
            this.sekreterGirisButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekreterGirisButon.BackgroundImage")));
            this.sekreterGirisButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sekreterGirisButon.Location = new System.Drawing.Point(335, 151);
            this.sekreterGirisButon.Name = "sekreterGirisButon";
            this.sekreterGirisButon.Size = new System.Drawing.Size(114, 87);
            this.sekreterGirisButon.TabIndex = 6;
            this.sekreterGirisButon.UseVisualStyleBackColor = true;
            this.sekreterGirisButon.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lucky Life Hospital";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(467, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekreterGirisButon);
            this.Controls.Add(this.doktorGirisButon);
            this.Controls.Add(this.hastaGirisButon);
            this.Name = "GirisForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastaGirisButon;
        private System.Windows.Forms.Button doktorGirisButon;
        private System.Windows.Forms.Button sekreterGirisButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}


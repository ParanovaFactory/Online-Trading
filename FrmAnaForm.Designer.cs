
namespace Online_Satış
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.BtnIstatistikler = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(159, 12);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(146, 84);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "Ketegori İşlemleri";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(311, 13);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(146, 84);
            this.BtnUrun.TabIndex = 1;
            this.BtnUrun.Text = "Ürün İşlemleri";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(13, 112);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(140, 84);
            this.BtnMusteri.TabIndex = 2;
            this.BtnMusteri.Text = "Müşteri İşlemleri";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // BtnIstatistikler
            // 
            this.BtnIstatistikler.Location = new System.Drawing.Point(311, 112);
            this.BtnIstatistikler.Name = "BtnIstatistikler";
            this.BtnIstatistikler.Size = new System.Drawing.Size(146, 84);
            this.BtnIstatistikler.TabIndex = 4;
            this.BtnIstatistikler.Text = "İstatistikler";
            this.BtnIstatistikler.UseVisualStyleBackColor = true;
            this.BtnIstatistikler.Click += new System.EventHandler(this.BtnIstatistikler_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.Location = new System.Drawing.Point(159, 112);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(146, 84);
            this.BtnSatis.TabIndex = 3;
            this.BtnSatis.Text = "Satış İşlemleri";
            this.BtnSatis.UseVisualStyleBackColor = true;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 208);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnIstatistikler);
            this.Controls.Add(this.BtnSatis);
            this.Controls.Add(this.BtnMusteri);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Online Satış";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnMusteri;
        private System.Windows.Forms.Button BtnIstatistikler;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
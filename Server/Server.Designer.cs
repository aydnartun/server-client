namespace Server
{
    partial class frm_server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_server));
            this.asagı_al = new System.Windows.Forms.PictureBox();
            this.kapat = new System.Windows.Forms.PictureBox();
            this.ust_bar = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.txt_mesaj = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.asagı_al)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // asagı_al
            // 
            this.asagı_al.BackColor = System.Drawing.Color.DimGray;
            this.asagı_al.Image = ((System.Drawing.Image)(resources.GetObject("asagı_al.Image")));
            this.asagı_al.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asagı_al.Location = new System.Drawing.Point(526, 4);
            this.asagı_al.Name = "asagı_al";
            this.asagı_al.Size = new System.Drawing.Size(31, 32);
            this.asagı_al.TabIndex = 7;
            this.asagı_al.TabStop = false;
            this.asagı_al.Click += new System.EventHandler(this.asagı_al_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.DimGray;
            this.kapat.Image = ((System.Drawing.Image)(resources.GetObject("kapat.Image")));
            this.kapat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kapat.Location = new System.Drawing.Point(559, 4);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(31, 32);
            this.kapat.TabIndex = 6;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ust_bar
            // 
            this.ust_bar.BackColor = System.Drawing.Color.DarkGray;
            this.ust_bar.Image = ((System.Drawing.Image)(resources.GetObject("ust_bar.Image")));
            this.ust_bar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ust_bar.Location = new System.Drawing.Point(0, 0);
            this.ust_bar.Name = "ust_bar";
            this.ust_bar.Size = new System.Drawing.Size(598, 42);
            this.ust_bar.TabIndex = 5;
            this.ust_bar.TabStop = false;
            this.ust_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ust_bar_MouseDown);
            this.ust_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ust_bar_MouseMove);
            this.ust_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ust_bar_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(12, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 204);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btn_baslat
            // 
            this.btn_baslat.BackColor = System.Drawing.Color.DarkGray;
            this.btn_baslat.ForeColor = System.Drawing.Color.Transparent;
            this.btn_baslat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_baslat.Location = new System.Drawing.Point(372, 65);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(106, 26);
            this.btn_baslat.TabIndex = 9;
            this.btn_baslat.Text = "Sohbeti Başlat";
            this.btn_baslat.UseVisualStyleBackColor = false;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.BackColor = System.Drawing.Color.DarkGray;
            this.btn_durdur.ForeColor = System.Drawing.Color.Transparent;
            this.btn_durdur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_durdur.Location = new System.Drawing.Point(484, 65);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(106, 26);
            this.btn_durdur.TabIndex = 9;
            this.btn_durdur.Text = "Sohbeti Durdur";
            this.btn_durdur.UseVisualStyleBackColor = false;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(12, 307);
            this.txt_mesaj.Multiline = true;
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(466, 26);
            this.txt_mesaj.TabIndex = 10;
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.Color.DarkGray;
            this.btn_gonder.ForeColor = System.Drawing.Color.Transparent;
            this.btn_gonder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gonder.Location = new System.Drawing.Point(484, 307);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(106, 26);
            this.btn_gonder.TabIndex = 9;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = false;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(217, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "www.denizartunaydin.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 24);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frm_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.asagı_al);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.ust_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_server";
            ((System.ComponentModel.ISupportInitialize)(this.asagı_al)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ust_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox asagı_al;
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.PictureBox ust_bar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.TextBox txt_mesaj;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


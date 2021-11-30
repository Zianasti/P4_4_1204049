namespace P4_4_1204049
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNopinjam = new System.Windows.Forms.TextBox();
            this.tbPeminjam = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbJmlBuku = new System.Windows.Forms.TextBox();
            this.tbJdlBuku = new System.Windows.Forms.TextBox();
            this.tbKodePetugas = new System.Windows.Forms.TextBox();
            this.dtTglPinjam = new System.Windows.Forms.DateTimePicker();
            this.dtTglKembali = new System.Windows.Forms.DateTimePicker();
            this.Tampilkan = new System.Windows.Forms.Button();
            this.Keluar = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Peminjaman Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(62, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Pinjam                      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(62, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peminjam                        :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(62, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email                               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(59, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = " Jumlah Buku                  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(62, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Judul Buku                     :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(59, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = " Tanggal Pinjam             :\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(62, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tanggal Pengembalian  :\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(62, 377);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kode Petugas                  :";
            // 
            // tbNopinjam
            // 
            this.tbNopinjam.Location = new System.Drawing.Point(292, 78);
            this.tbNopinjam.Name = "tbNopinjam";
            this.tbNopinjam.Size = new System.Drawing.Size(341, 31);
            this.tbNopinjam.TabIndex = 9;
            this.tbNopinjam.Leave += new System.EventHandler(this.tbNopinjam_Leave);
            // 
            // tbPeminjam
            // 
            this.tbPeminjam.Location = new System.Drawing.Point(292, 119);
            this.tbPeminjam.Name = "tbPeminjam";
            this.tbPeminjam.Size = new System.Drawing.Size(341, 31);
            this.tbPeminjam.TabIndex = 10;
            this.tbPeminjam.Leave += new System.EventHandler(this.tbPeminjam_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(292, 163);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(341, 31);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbJmlBuku
            // 
            this.tbJmlBuku.Location = new System.Drawing.Point(292, 203);
            this.tbJmlBuku.Name = "tbJmlBuku";
            this.tbJmlBuku.Size = new System.Drawing.Size(341, 31);
            this.tbJmlBuku.TabIndex = 12;
            this.tbJmlBuku.Leave += new System.EventHandler(this.tbJmlBuku_Leave);
            // 
            // tbJdlBuku
            // 
            this.tbJdlBuku.Location = new System.Drawing.Point(292, 247);
            this.tbJdlBuku.Name = "tbJdlBuku";
            this.tbJdlBuku.Size = new System.Drawing.Size(341, 31);
            this.tbJdlBuku.TabIndex = 13;
            this.tbJdlBuku.Leave += new System.EventHandler(this.tbJdlBuku_Leave);
            // 
            // tbKodePetugas
            // 
            this.tbKodePetugas.Location = new System.Drawing.Point(292, 377);
            this.tbKodePetugas.Name = "tbKodePetugas";
            this.tbKodePetugas.Size = new System.Drawing.Size(341, 31);
            this.tbKodePetugas.TabIndex = 14;
            this.tbKodePetugas.Leave += new System.EventHandler(this.tbKodePetugas_Leave);
            // 
            // dtTglPinjam
            // 
            this.dtTglPinjam.Location = new System.Drawing.Point(292, 290);
            this.dtTglPinjam.Name = "dtTglPinjam";
            this.dtTglPinjam.Size = new System.Drawing.Size(341, 31);
            this.dtTglPinjam.TabIndex = 15;
            // 
            // dtTglKembali
            // 
            this.dtTglKembali.Location = new System.Drawing.Point(292, 333);
            this.dtTglKembali.Name = "dtTglKembali";
            this.dtTglKembali.Size = new System.Drawing.Size(341, 31);
            this.dtTglKembali.TabIndex = 16;
            // 
            // Tampilkan
            // 
            this.Tampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tampilkan.Location = new System.Drawing.Point(178, 437);
            this.Tampilkan.Name = "Tampilkan";
            this.Tampilkan.Size = new System.Drawing.Size(132, 37);
            this.Tampilkan.TabIndex = 17;
            this.Tampilkan.Text = "Tampilkan";
            this.Tampilkan.UseVisualStyleBackColor = false;
            this.Tampilkan.Click += new System.EventHandler(this.Tampilkan_Click);
            // 
            // Keluar
            // 
            this.Keluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Keluar.Location = new System.Drawing.Point(362, 437);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(132, 37);
            this.Keluar.TabIndex = 18;
            this.Keluar.Text = "Keluar";
            this.Keluar.UseVisualStyleBackColor = false;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 505);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.Tampilkan);
            this.Controls.Add(this.dtTglKembali);
            this.Controls.Add(this.dtTglPinjam);
            this.Controls.Add(this.tbKodePetugas);
            this.Controls.Add(this.tbJdlBuku);
            this.Controls.Add(this.tbJmlBuku);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPeminjam);
            this.Controls.Add(this.tbNopinjam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("High Tower Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Perpustakaan Pelangi";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNopinjam;
        private System.Windows.Forms.TextBox tbPeminjam;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbJmlBuku;
        private System.Windows.Forms.TextBox tbJdlBuku;
        private System.Windows.Forms.TextBox tbKodePetugas;
        private System.Windows.Forms.DateTimePicker dtTglPinjam;
        private System.Windows.Forms.DateTimePicker dtTglKembali;
        private System.Windows.Forms.Button Tampilkan;
        private System.Windows.Forms.Button Keluar;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}


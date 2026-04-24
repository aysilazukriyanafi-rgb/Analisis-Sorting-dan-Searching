namespace Project_Searching_dan_Sorting_Data_Nilai_Mahasiswa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabelDataMahasiswa = new GroupBox();
            dgvData = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Nilai = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnBruteForceSearch = new Button();
            btnCari = new TextBox();
            btnSequentialSearch = new Button();
            button2 = new Button();
            dgvPerbandingan = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button7 = new Button();
            cmbAlgoritma = new ComboBox();
            dgvPerbandinganAlgoritma = new GroupBox();
            lblPertukaran = new Label();
            lblPerbandingan = new Label();
            trackBar1 = new TrackBar();
            trackBarKecepatan = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            btnAutoPlay = new Button();
            btnReset = new Button();
            lblLangkah = new Label();
            lblKeterangan = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            TabelDataMahasiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerbandingan).BeginInit();
            groupBox3.SuspendLayout();
            dgvPerbandinganAlgoritma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // TabelDataMahasiswa
            // 
            TabelDataMahasiswa.Controls.Add(dgvData);
            TabelDataMahasiswa.Location = new Point(12, 12);
            TabelDataMahasiswa.Name = "TabelDataMahasiswa";
            TabelDataMahasiswa.Size = new Size(428, 375);
            TabelDataMahasiswa.TabIndex = 0;
            TabelDataMahasiswa.TabStop = false;
            TabelDataMahasiswa.Text = "Tabel Data Mahasiswa";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { No, Nama, Nilai });
            dgvData.Location = new Point(6, 30);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersVisible = false;
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(416, 323);
            dgvData.TabIndex = 0;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 8;
            Nama.Name = "Nama";
            // 
            // Nilai
            // 
            Nilai.HeaderText = "Nilai";
            Nilai.MinimumWidth = 8;
            Nilai.Name = "Nilai";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBruteForceSearch);
            groupBox2.Controls.Add(btnCari);
            groupBox2.Controls.Add(btnSequentialSearch);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(452, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Algoritma Searching";
            // 
            // btnBruteForceSearch
            // 
            btnBruteForceSearch.Location = new Point(304, 67);
            btnBruteForceSearch.Name = "btnBruteForceSearch";
            btnBruteForceSearch.Size = new Size(359, 34);
            btnBruteForceSearch.TabIndex = 9;
            btnBruteForceSearch.Text = "Brute Force Search";
            btnBruteForceSearch.UseVisualStyleBackColor = true;
            btnBruteForceSearch.Click += btnBruteForceSearch_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(16, 30);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(272, 31);
            btnCari.TabIndex = 1;
            // 
            // btnSequentialSearch
            // 
            btnSequentialSearch.Location = new Point(298, 28);
            btnSequentialSearch.Name = "btnSequentialSearch";
            btnSequentialSearch.Size = new Size(184, 34);
            btnSequentialSearch.TabIndex = 7;
            btnSequentialSearch.Text = "Sequential Search";
            btnSequentialSearch.UseVisualStyleBackColor = true;
            btnSequentialSearch.Click += btnSequentialSearch_Click;
            // 
            // button2
            // 
            button2.Location = new Point(491, 27);
            button2.Name = "button2";
            button2.Size = new Size(172, 34);
            button2.TabIndex = 8;
            button2.Text = "Binary Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnBinary_Click;
            // 
            // dgvPerbandingan
            // 
            dgvPerbandingan.AllowUserToAddRows = false;
            dgvPerbandingan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerbandingan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerbandingan.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dgvPerbandingan.Location = new Point(6, 30);
            dgvPerbandingan.Name = "dgvPerbandingan";
            dgvPerbandingan.RowHeadersVisible = false;
            dgvPerbandingan.RowHeadersWidth = 62;
            dgvPerbandingan.Size = new Size(395, 305);
            dgvPerbandingan.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.FillWeight = 91.83672F;
            Column4.HeaderText = "Algoritma";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 109.965378F;
            Column5.HeaderText = "Perbandingan";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 98.197876F;
            Column6.HeaderText = "Pertukaran";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(cmbAlgoritma);
            groupBox3.Location = new Point(452, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(699, 60);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Algoritma Sorting:";
            // 
            // button7
            // 
            button7.Location = new Point(429, 19);
            button7.Name = "button7";
            button7.Size = new Size(264, 34);
            button7.TabIndex = 12;
            button7.Text = "Tampilkan Tabel Perbandingan";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnTabelPerbandingan_Click;
            // 
            // cmbAlgoritma
            // 
            cmbAlgoritma.FormattingEnabled = true;
            cmbAlgoritma.Items.AddRange(new object[] { "Bubble Sort", "Selection Sort", "Insertion Sort", "Counting Sort" });
            cmbAlgoritma.Location = new Point(162, 0);
            cmbAlgoritma.Name = "cmbAlgoritma";
            cmbAlgoritma.Size = new Size(182, 33);
            cmbAlgoritma.TabIndex = 11;
            cmbAlgoritma.Text = "Bubble Sort";
            cmbAlgoritma.SelectedIndexChanged += cmbAlgoritma_SelectedIndexChanged;
            // 
            // dgvPerbandinganAlgoritma
            // 
            dgvPerbandinganAlgoritma.Controls.Add(lblPertukaran);
            dgvPerbandinganAlgoritma.Controls.Add(lblPerbandingan);
            dgvPerbandinganAlgoritma.Controls.Add(dgvPerbandingan);
            dgvPerbandinganAlgoritma.Location = new Point(750, 234);
            dgvPerbandinganAlgoritma.Name = "dgvPerbandinganAlgoritma";
            dgvPerbandinganAlgoritma.Size = new Size(407, 392);
            dgvPerbandinganAlgoritma.TabIndex = 3;
            dgvPerbandinganAlgoritma.TabStop = false;
            dgvPerbandinganAlgoritma.Text = "Tabel Perbandingan Algoritma";
            // 
            // lblPertukaran
            // 
            lblPertukaran.AutoSize = true;
            lblPertukaran.Location = new Point(240, 338);
            lblPertukaran.Name = "lblPertukaran";
            lblPertukaran.Size = new Size(109, 25);
            lblPertukaran.TabIndex = 2;
            lblPertukaran.Text = "Pertukaran:0";
            // 
            // lblPerbandingan
            // 
            lblPerbandingan.AutoSize = true;
            lblPerbandingan.Location = new Point(16, 338);
            lblPerbandingan.Name = "lblPerbandingan";
            lblPerbandingan.Size = new Size(135, 25);
            lblPerbandingan.TabIndex = 1;
            lblPerbandingan.Text = "Perbandingan:0";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(766, 674);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(349, 69);
            trackBar1.TabIndex = 5;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // trackBarKecepatan
            // 
            trackBarKecepatan.AutoSize = true;
            trackBarKecepatan.Location = new Point(663, 674);
            trackBarKecepatan.Name = "trackBarKecepatan";
            trackBarKecepatan.Size = new Size(97, 25);
            trackBarKecepatan.TabIndex = 11;
            trackBarKecepatan.Text = "Kecepatan:";
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(18, 665);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(112, 45);
            btnPrev.TabIndex = 12;
            btnPrev.Text = "<Prev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(158, 665);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 45);
            btnNext.TabIndex = 13;
            btnNext.Text = ">Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnAutoPlay
            // 
            btnAutoPlay.Location = new Point(309, 665);
            btnAutoPlay.Name = "btnAutoPlay";
            btnAutoPlay.Size = new Size(171, 45);
            btnAutoPlay.TabIndex = 14;
            btnAutoPlay.Text = "Auto\r\n";
            btnAutoPlay.UseVisualStyleBackColor = true;
            btnAutoPlay.Click += btnAutoPlay_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(504, 665);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 45);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // lblLangkah
            // 
            lblLangkah.AutoSize = true;
            lblLangkah.Location = new Point(34, 421);
            lblLangkah.Name = "lblLangkah";
            lblLangkah.Size = new Size(78, 25);
            lblLangkah.TabIndex = 16;
            lblLangkah.Text = "Langkah";
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Location = new Point(34, 468);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(101, 25);
            lblKeterangan.TabIndex = 17;
            lblKeterangan.Text = "Keterangan";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 722);
            Controls.Add(lblKeterangan);
            Controls.Add(lblLangkah);
            Controls.Add(btnReset);
            Controls.Add(btnAutoPlay);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(trackBarKecepatan);
            Controls.Add(trackBar1);
            Controls.Add(dgvPerbandinganAlgoritma);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(TabelDataMahasiswa);
            Name = "Form1";
            Text = "Form1";
            TabelDataMahasiswa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerbandingan).EndInit();
            groupBox3.ResumeLayout(false);
            dgvPerbandinganAlgoritma.ResumeLayout(false);
            dgvPerbandinganAlgoritma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TabelDataMahasiswa;
        private DataGridView dgvData;
        private GroupBox groupBox2;
        private DataGridView dgvPerbandingan;
        private GroupBox groupBox3;
        private GroupBox dgvPerbandinganAlgoritma;
        private TextBox btnCari;
        private TrackBar trackBar1;
        private Button btnSequentialSearch;
        private Button button2;
        private ComboBox cmbAlgoritma;
        private Button button7;
        private Label label1;
        private Label trackBarKecepatan;
        private Button btnPrev;
        private Button btnNext;
        private Button btnAutoPlay;
        private Button btnReset;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label lblLangkah;
        private Label lblKeterangan;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Nilai;
        private Label lblPertukaran;
        private Label lblPerbandingan;
        private System.Windows.Forms.Timer timer1;
        private Button btnBruteForceSearch;
    }
}

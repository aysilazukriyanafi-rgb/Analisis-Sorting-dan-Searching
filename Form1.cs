using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_Searching_dan_Sorting_Data_Nilai_Mahasiswa
{
    public partial class Form1 : Form
    {
        // Data Master
        string[] namaAwal = { "Andi", "Budi", "Citra", "Deni", "Eka", "Fajar", "Gita", "Hana", "Ilham", "Joko", "Kiki", "Lina", "Miko", "Nadia", "Oscar", "Putri", "Qori", "Raka", "Sari", "Tono", "Umar", "Vina", "Widi", "Xena", "Yoga" };
        int[] nilaiAwal = { 78, 55, 90, 42, 67, 88, 33, 75, 91, 60, 48, 82, 55, 70, 39, 85, 63, 77, 91, 50, 68, 44, 80, 57, 73 };

        string[] nama;
        int[] nilai;

        // List Penyimpan Langkah untuk Visualisasi
        List<int[]> stepsNilai = new List<int[]>();
        List<string[]> stepsNama = new List<string[]>();
        List<string> stepKeterangan = new List<string>();
        List<int[]> stepKuning = new List<int[]>();
        List<int[]> stepMerah = new List<int[]>();
        List<int[]> stepHijau = new List<int[]>();

        int currentStep = 0;
        System.Windows.Forms.Timer timerAutoPlay = new System.Windows.Forms.Timer();

        // Statistik untuk Tabel Perbandingan (0=Bubble, 1=Selection, 2=Insertion, 3=Counting)
        int[] hasilPerbandingan = new int[4];
        int[] hasilPertukaran = new int[4];

        public Form1()
        {
            InitializeComponent();
            SetupTimer();
            ResetData();
        }

        void SetupTimer()
        {
            timerAutoPlay.Tick += (s, e) =>
            {
                if (currentStep < stepsNilai.Count - 1)
                {
                    currentStep++;
                    TampilkanDataGrid(currentStep);
                }
                else
                {
                    timerAutoPlay.Stop();
                    btnAutoPlay.Text = "▶ Auto Play";
                }
            };
        }

        void SimpanLangkah(int[] nilaiSaatIni, string[] namaSaatIni, int[] kuning, int[] merah, int[] hijau, string keterangan)
        {
            stepsNilai.Add((int[])nilaiSaatIni.Clone());
            stepsNama.Add((string[])namaSaatIni.Clone());
            stepKuning.Add(kuning);
            stepMerah.Add(merah);
            stepHijau.Add(hijau);
            stepKeterangan.Add(keterangan);
        }

        void TampilkanDataGrid(int langkah)
        {
            if (stepsNilai.Count == 0) return;

            int[] nilaiStep = stepsNilai[langkah];
            string[] namaStep = stepsNama[langkah];
            int[] kuning = stepKuning[langkah];
            int[] merah = stepMerah[langkah];
            int[] hijau = stepHijau[langkah];

            for (int i = 0; i < namaStep.Length; i++)
            {
                dgvData.Rows[i].Cells[0].Value = i + 1;
                dgvData.Rows[i].Cells[1].Value = namaStep[i];
                dgvData.Rows[i].Cells[2].Value = nilaiStep[i];

                if (Array.IndexOf(merah, i) >= 0)
                    dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Salmon;
                else if (Array.IndexOf(kuning, i) >= 0)
                    dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                else if (Array.IndexOf(hijau, i) >= 0)
                    dgvData.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    dgvData.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }

            lblLangkah.Text = $"Langkah ke-{langkah + 1} dari {stepsNilai.Count}";
            lblKeterangan.Text = stepKeterangan[langkah];
        }

        void ResetData()
        {
            nama = (string[])namaAwal.Clone();
            nilai = (int[])nilaiAwal.Clone();
            stepsNilai.Clear();
            stepsNama.Clear();
            stepKeterangan.Clear();
            stepKuning.Clear();
            stepMerah.Clear();
            stepHijau.Clear();
            currentStep = 0;

            dgvData.Rows.Clear();
            for (int i = 0; i < namaAwal.Length; i++)
                dgvData.Rows.Add(i + 1, namaAwal[i], nilaiAwal[i]);

            lblKeterangan.Text = "Data di-reset.";
            lblPerbandingan.Text = "Perbandingan: 0";
            lblPertukaran.Text = "Pertukaran: 0";
        }


        // --- ALGORITMA SORTING ---

        void JalankanBubbleSort()
        {
            ResetData();
            int perbandingan = 0, pertukaran = 0;
            List<int> sudahUrut = new List<int>();

            for (int i = 0; i < nilai.Length - 1; i++)
            {
                bool adaTukar = false;
                for (int j = 0; j < nilai.Length - i - 1; j++)
                {
                    perbandingan++;
                    SimpanLangkah(nilai, nama, new int[] { j, j + 1 }, new int[] { }, sudahUrut.ToArray(), $"Membandingkan {nama[j]} & {nama[j + 1]}");

                    if (nilai[j] > nilai[j + 1])
                    {
                        int tempV = nilai[j]; nilai[j] = nilai[j + 1]; nilai[j + 1] = tempV;
                        string tempN = nama[j]; nama[j] = nama[j + 1]; nama[j + 1] = tempN;
                        pertukaran++;
                        adaTukar = true;
                        SimpanLangkah(nilai, nama, new int[] { }, new int[] { j, j + 1 }, sudahUrut.ToArray(), "Tukar posisi!");
                    }
                }
                sudahUrut.Add(nilai.Length - i - 1);
                if (!adaTukar) break;
            }

            // Catat Statistik
            hasilPerbandingan[0] = perbandingan;
            hasilPertukaran[0] = pertukaran;
            FinalisasiSort("Bubble Sort", perbandingan, pertukaran);
        }

        void JalankanSelectionSort()
        {
            // 1. Reset histori sebelum mulai agar tidak bertumpuk
            ResetData();
            stepsNilai.Clear();
            stepsNama.Clear();
            stepKeterangan.Clear();
            // ... reset list warna lainnya ...

            int perbandingan = 0, pertukaran = 0;
            List<int> sudahUrut = new List<int>();

            for (int i = 0; i < nilai.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < nilai.Length; j++)
                {
                    perbandingan++;
                    // GUNAKAN .Clone() agar data tiap langkah tersimpan permanen
                    SimpanLangkah((int[])nilai.Clone(), (string[])nama.Clone(),
                        new int[] { j, minIdx }, new int[] { }, sudahUrut.ToArray(),
                        $"Mencari nilai terkecil: Membandingkan {nama[j]} dengan {nama[minIdx]}");

                    if (nilai[j] < nilai[minIdx]) minIdx = j;
                }

                if (minIdx != i)
                {
                    int tempV = nilai[i]; nilai[i] = nilai[minIdx]; nilai[minIdx] = tempV;
                    string tempN = nama[i]; nama[i] = nama[minIdx]; nama[minIdx] = tempN;
                    pertukaran++;

                    SimpanLangkah((int[])nilai.Clone(), (string[])nama.Clone(),
                        new int[] { }, new int[] { i, minIdx }, sudahUrut.ToArray(),
                        $"Tukar: {nama[i]} (Nilai terkecil ditemukan) ke posisi depan.");
                }
                sudahUrut.Add(i);
            }

            // Pastikan index hasilPerbandingan dan hasilPertukaran sesuai (misal index 1 untuk Selection)
            if (hasilPerbandingan.Length > 1) hasilPerbandingan[1] = perbandingan;
            if (hasilPertukaran.Length > 1) hasilPertukaran[1] = pertukaran;

            FinalisasiSort("Selection Sort", perbandingan, pertukaran);
        }

        void JalankanInsertionSort()
        {
            ResetData();
            int perbandingan = 0, pergeseran = 0;

            for (int i = 1; i < nilai.Length; i++)
            {
                int keyV = nilai[i];
                string keyN = nama[i];
                int j = i - 1;

                SimpanLangkah(nilai, nama, new int[] { i }, new int[] { }, new int[] { }, $"Ambil {keyN}");

                while (j >= 0 && nilai[j] > keyV)
                {
                    perbandingan++;
                    nilai[j + 1] = nilai[j];
                    nama[j + 1] = nama[j];
                    pergeseran++;
                    SimpanLangkah(nilai, nama, new int[] { j }, new int[] { j + 1 }, new int[] { }, "Geser elemen...");
                    j--;
                }
                if (j >= 0) perbandingan++;

                nilai[j + 1] = keyV;
                nama[j + 1] = keyN;
                SimpanLangkah(nilai, nama, new int[] { }, new int[] { }, Enumerable.Range(0, i + 1).ToArray(), "Sisipkan elemen.");
            }
            hasilPerbandingan[2] = perbandingan;
            hasilPertukaran[2] = pergeseran;
            FinalisasiSort("Insertion Sort", perbandingan, pergeseran);
        }

        void JalankanCountingSort()
        {
            ResetData();
            // Logika counting sort Anda sudah benar di codingan awal
            // ... (Copy logika counting sort Anda ke sini)
            hasilPerbandingan[3] = 0;
            hasilPertukaran[3] = nilai.Length;
            FinalisasiSort("Counting Sort", 0, nilai.Length);
        }

        void FinalisasiSort(string algo, int perb, int tukar)
        {
            SimpanLangkah(nilai, nama, new int[] { }, new int[] { }, Enumerable.Range(0, nilai.Length).ToArray(), $"{algo} Selesai!");
            lblPerbandingan.Text = $"Perbandingan: {perb}";
            lblPertukaran.Text = $"Pertukaran: {tukar}";
            currentStep = 0;
            TampilkanDataGrid(0);
        }

        // --- ALGORITMA SEARCHING ---

        void JalankanSequentialSearch(int cari)
        {
            ResetData();
            int langkah = 0;
            bool ketemu = false;
            for (int i = 0; i < nilai.Length; i++)
            {
                langkah++;
                if (nilai[i] == cari)
                {
                    SimpanLangkah(nilai, nama, new int[] { }, new int[] { }, new int[] { i }, "Ditemukan!");
                    ketemu = true;
                }
                else
                {
                    SimpanLangkah(nilai, nama, new int[] { i }, new int[] { }, new int[] { }, "Memeriksa...");
                }
            }
            TampilkanDataGrid(0);
        }

        void JalankanBinarySearch(int cari)
        {
            // Binary search butuh data terurut
            JalankanBubbleSort(); // Urutkan dulu
            stepsNilai.Clear(); stepsNama.Clear(); stepKeterangan.Clear(); // Bersihkan history sort

            int low = 0, high = nilai.Length - 1, langkah = 0;
            while (low <= high)
            {
                langkah++;
                int mid = (low + high) / 2;
                SimpanLangkah(nilai, nama, new int[] { mid }, new int[] { }, Enumerable.Range(low, high - low + 1).ToArray(), $"Cek mid: {nilai[mid]}");

                if (nilai[mid] == cari)
                {
                    SimpanLangkah(nilai, nama, new int[] { }, new int[] { }, new int[] { mid }, "Ditemukan!");
                    break;
                }
                else if (nilai[mid] < cari) low = mid + 1;
                else high = mid - 1;
            }
            TampilkanDataGrid(0);
        }

        void JalankanBruteForceSearch(int cari)
        {
            ResetData();
            int langkah = 0;
            bool ketemu = false;

            for (int i = 0; i < nilai.Length; i++)
            {
                langkah++;

                // Visualisasi cek satu per satu (brute force)
                if (nilai[i] == cari)
                {
                    SimpanLangkah(
                        nilai, nama,
                        new int[] { },
                        new int[] { },
                        new int[] { i },
                        $"Brute Force: Data ditemukan di index {i}"
                    );
                    ketemu = true;
                    break;
                }
                else
                {
                    SimpanLangkah(
                        nilai, nama,
                        new int[] { i },
                        new int[] { },
                        new int[] { },
                        $"Brute Force: Cek {nama[i]} ({nilai[i]})"
                    );
                }
            }

            if (!ketemu)
            {
                SimpanLangkah(
                    nilai, nama,
                    new int[] { },
                    new int[] { },
                    new int[] { },
                    "Brute Force: Data tidak ditemukan"
                );
            }

            TampilkanDataGrid(0);
        }

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(btnCari.Text, out int val)) JalankanSequentialSearch(val);
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (int.TryParse(btnCari.Text, out int val)) JalankanBinarySearch(val);
        }

        private void btnBruteForceSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(btnCari.Text, out int val)) JalankanBruteForceSearch(val);
        }



        private void btnTabelPerbandingan_Click(object sender, EventArgs e)
        {

            // Pastikan Grid dikosongkan dulu lalu diisi data terbaru
            dgvPerbandingan.Rows.Clear();
            dgvPerbandingan.Rows.Add("Bubble Sort", hasilPerbandingan[0], hasilPertukaran[0]);
            dgvPerbandingan.Rows.Add("Selection Sort", hasilPerbandingan[1], hasilPertukaran[1]);
            dgvPerbandingan.Rows.Add("Insertion Sort", hasilPerbandingan[2], hasilPertukaran[2]);
            dgvPerbandingan.Rows.Add("Counting Sort", hasilPerbandingan[3], hasilPertukaran[3]);
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep < stepsNilai.Count - 1) { currentStep++; TampilkanDataGrid(currentStep); }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentStep > 0) { currentStep--; TampilkanDataGrid(currentStep); }
        }


        private void cmbAlgoritma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetData(); // Bersihkan histori lama

            int[] dataNilai = (int[])nilaiAwal.Clone();
            string[] dataNama = (string[])namaAwal.Clone();
            string pilihan = cmbAlgoritma.Text;

            if (pilihan == "Bubble Sort")
            {
                JalankanBubbleSort(); // Memanggil fungsi yang sudah ada di atas
            }
            else if (pilihan == "Selection Sort")
            {
                JalankanSelectionSort(); // SEBELUMNYA: JalankanSelection (Maka 0 reference)
            }
            else if (pilihan == "Insertion Sort")
            {
                JalankanInsertionSort();
            }
            else if (pilihan == "Counting Sort")
            {
                JalankanCountingSort();
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

            // 1. Matikan Timer jika Auto Play sedang jalan
            timer1.Stop();
            btnAutoPlay.Text = "Auto Play";

            // 2. Kosongkan semua "Penyimpanan" langkah (List Histori)

            stepsNilai.Clear();
            stepsNama.Clear();
            stepKeterangan.Clear();
            stepKuning.Clear();
            stepMerah.Clear();
            stepHijau.Clear();

            // 3. Kembalikan index langkah ke 0
            currentStep = 0;

            // 4. Isi kembali tabel dengan data asli (nilaiAwal)
            dgvData.Rows.Clear();
            for (int i = 0; i < nilaiAwal.Length; i++)
            {
                dgvData.Rows.Add(i + 1, namaAwal[i], nilaiAwal[i]);
                // Hilangkan warna latar belakang baris (kembalikan ke putih)
                dgvData.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }

            // 5. Reset Label Informasi
            lblLangkah.Text = "Langkah: 0";
            lblKeterangan.Text = "Silakan pilih algoritma kembali.";

            // 6. Reset ComboBox
            cmbAlgoritma.SelectedIndex = -1;

            MessageBox.Show("Aplikasi berhasil di-reset!");
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Jika masih ada langkah tersisa, klik tombol Next secara otomatis
            if (currentStep < stepsNilai.Count - 1)
            {
                btnNext.PerformClick();
            }
            else
            {
                timer1.Stop(); // Berhenti jika sudah langkah terakhir
                btnAutoPlay.Text = "Auto Play";
            }
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            int kecepatan = 1000 - (trackBar1.Value * 90);
            timer1.Interval = kecepatan;
        }

        private void btnAutoPlay_Click(object sender, EventArgs e)
        {

            if (timerAutoPlay.Enabled)
            {
                timerAutoPlay.Stop();
                btnAutoPlay.Text = "▶ Auto Play";
            }
            else
            {
                // Pastikan ada langkah yang bisa dijalankan
                if (stepsNilai.Count > 0)
                {
                    timerAutoPlay.Start();
                    btnAutoPlay.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Pilih algoritma sorting terlebih dahulu!");
                }
            }
        }


    }

}
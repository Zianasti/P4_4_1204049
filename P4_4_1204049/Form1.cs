using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNopinjam_Leave(object sender, EventArgs e)
        {
            if(tbNopinjam.Text.Length > 4) //Length Validator
            {
                epCorrect.SetError(tbNopinjam, "");
                epWarning.SetError(tbNopinjam, "No. Pinjam hanya boleh diisi oleh 4 angka");
                epWrong.SetError(tbNopinjam, "");
            }
            else if ((tbNopinjam.Text).All(Char.IsNumber)) 
            {
                epCorrect.SetError(tbNopinjam, "Betul !");
                epWarning.SetError(tbNopinjam, "");
                epWrong.SetError(tbNopinjam, "");
            }
            else
            {
                epCorrect.SetError(tbNopinjam, "");
                epWarning.SetError(tbNopinjam, "");
                epWrong.SetError(tbNopinjam, "Inputan hanya boleh angka !");
            }
            if (tbNopinjam.Text == "")
            {
                epCorrect.SetError(tbNopinjam, "");
                epWarning.SetError(tbNopinjam, "Kolom No Pinjam tidak boleh kosong !");
                epWrong.SetError(tbNopinjam, "");
            }
            else
            { }
        }

        private void tbPeminjam_Leave(object sender, EventArgs e)
        {
            if (tbPeminjam.Text == "")
            {
                epWarning.SetError(tbPeminjam, "Textbox Peminjam tidak boleh kosong!"); //Required Validator
                epWrong.SetError(tbPeminjam, "");
                epCorrect.SetError(tbPeminjam, "");
            }
            else
            {
                if ((tbPeminjam.Text).Any(Char.IsLetter)) //Char TextBox
                {
                    epWarning.SetError(tbPeminjam, "");
                    epWrong.SetError(tbPeminjam, "");
                    epCorrect.SetError(tbPeminjam, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbPeminjam, "Inputan hanya boleh huruf!");
                    epWarning.SetError(tbPeminjam, "");
                    epCorrect.SetError(tbPeminjam, "");
                }
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "") //Comparison
            {
                epWarning.SetError(tbEmail, "Textbox Email tidak boleh kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$")) //Regex Validator
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format email salah!\nContoh: a@b.c");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }

        }

        private void tbJmlBuku_Leave(object sender, EventArgs e)
        {
            if (tbJmlBuku.Text == "")
            {
                epWarning.SetError(tbJmlBuku, "Textbox Jumlah Buku tidak boleh kosong!");
                epWrong.SetError(tbJmlBuku, "");
                epCorrect.SetError(tbJmlBuku, "");
            }
            else
            {
                if ((tbJmlBuku.Text).All(Char.IsNumber)) //Numeric TextBox
                {
                    epCorrect.SetError(tbJmlBuku, "Betul!");
                    epWarning.SetError(tbJmlBuku, "");
                    epWrong.SetError(tbJmlBuku, "");
                }
                else
                {
                    epCorrect.SetError(tbJmlBuku, "");
                    epWarning.SetError(tbJmlBuku, "");
                    epWrong.SetError(tbJmlBuku, "Inputan hanya boleh angka!");
                }
            }
        }

        private void tbJdlBuku_Leave(object sender, EventArgs e)
        {
            if (tbJdlBuku.Text == "")
            {
                epWarning.SetError(tbJdlBuku, "Textbox Judul Buku tidak boleh kosong!"); 
                epWrong.SetError(tbJdlBuku, "");
                epCorrect.SetError(tbJdlBuku, "");
            }
            else
            {
                if(tbJdlBuku.Text != tbJdlBuku.Text.ToUpper()) // Upper Case TextBox 
                {
                    epWarning.SetError(tbJdlBuku, "Gunakan Huruf Kapital !");
                    epWrong.SetError(tbJdlBuku, "");
                    epCorrect.SetError(tbJdlBuku, "");
                }
                else if ((tbJdlBuku.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(tbJdlBuku, "");
                    epWrong.SetError(tbJdlBuku, "");
                    epCorrect.SetError(tbJdlBuku, "Betul!");
                }
                else
                {
                    epWarning.SetError(tbJdlBuku, "");
                    epWrong.SetError(tbJdlBuku, "Inputan hanya boleh huruf !");
                    epCorrect.SetError(tbJdlBuku, "");
                }
            }
        }

        private void tbKodePetugas_Leave(object sender, EventArgs e)
        {
            if (tbKodePetugas.Text == "")
            {
                epWarning.SetError(tbKodePetugas, "Textbox Kode Petugas tidak boleh kosong!");
                epWrong.SetError(tbKodePetugas, "");
                epCorrect.SetError(tbKodePetugas, "");
            }
            else
            {
                if (tbKodePetugas.Text != tbKodePetugas.Text.ToLower()) // Lower Case TextBox 
                {
                    epWarning.SetError(tbKodePetugas, "Gunakan Huruf Kecil !");
                    epWrong.SetError(tbKodePetugas, "");
                    epCorrect.SetError(tbKodePetugas, "");
                }
                else if ((tbKodePetugas.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(tbKodePetugas, "");
                    epWrong.SetError(tbKodePetugas, "");
                    epCorrect.SetError(tbKodePetugas, "Betul!");
                }
                else
                {
                    epWarning.SetError(tbKodePetugas, "");
                    epWrong.SetError(tbKodePetugas, "Inputan hanya boleh huruf !");
                    epCorrect.SetError(tbKodePetugas, "");
                }
            }
        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "No. Pinjam : " + tbNopinjam.Text +
                "\nPeminjam : " + tbPeminjam.Text +
                "\nEmail : " + tbEmail.Text +
                "\nJumlah Buku : " + tbJmlBuku.Text +
                "\nJudul Buku : " + tbJdlBuku.Text +
                "\nTanggal Pinjam : " + dtTglPinjam.Text +
                "\nTanggal Kembali : " + dtTglKembali.Text +
                "\nKode Petugas : " + tbKodePetugas.Text,
                "Informasi Data Peminjam Buku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kasirapp : Form
    {
        public Kasirapp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tb_bayar.Text = "0";
            cb_jenisbarang.Text = "None";
            tb_harga.Text = "0";
            tb_jumlahbarang.Text = "0";
            txt_jumlah.Text = "1";
            txt_kembalian.Text = "Rp. 0";
            txt_totalharga.Text = "Rp. 0";
            tb_items.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

                tb_bayar.Text = "0";
                tb_jumlahbarang.Text = "0";
                cb_jenisbarang.Text = "None";
                tb_harga.Text = "0";
                txt_jumlah.Text = "1";
                txt_kembalian.Text = "Rp. 0";
                txt_totalharga.Text = "Rp. 0";
                tb_items.Text = "";
            

        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {

            if (tb_harga.Text == "" || tb_jumlahbarang.Text == "" || tb_bayar.Text == "" || cb_jenisbarang.Text == "None") {

                MessageBox.Show("Silahkan isi data dengan benar");
            
            }
            else
            {

                int harga = Int32.Parse(tb_harga.Text);
                int jumlahbarang = Int32.Parse(tb_jumlahbarang.Text);
                int jumlahuang = Int32.Parse(tb_bayar.Text);

               // int totalhargalama = Int32.Parse(txt_totalharga.Text);
                //int kembalianlama = Int32.Parse(txt_kembalian.Text);
                int totalharga = harga * jumlahbarang;
                int kembalian = jumlahuang - totalharga;

                txt_kembalian.Text = "Rp. " + kembalian;
                txt_totalharga.Text = "Rp. " + totalharga;
                txt_jumlah.Text = jumlahbarang.ToString();

                String lastitem = tb_items.Text;
                tb_items.Text = lastitem + "  " + cb_jenisbarang.Text;
           



                if (kembalian < 0)
                {
                    MessageBox.Show("Duit pembeli kurang" + kembalian);
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_totalharga_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_bayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void HARGA_Click(object sender, EventArgs e)
        {

        }

        private void tb_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cb_jenisbarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selecteditem = cb_jenisbarang.Text;


            if(selecteditem == "Kertas")
            {
                tb_harga.Text = "2500";
            }


            if (selecteditem == "Pensil")
            {
                tb_harga.Text = "1500";
            }

            if (selecteditem == "Pulpen")
            {
                tb_harga.Text = "3500";
            }


            if (selecteditem == "Pulpen")
            {
                tb_harga.Text = "3500";
            }

            if (selecteditem == "Buku Tulis")
            {
                tb_harga.Text = "4500";
            }


            if (selecteditem == "Penghapus")
            {
                tb_harga.Text = "1000";
            }

            if (selecteditem == "Rautan")
            {
                tb_harga.Text = "7000";
            }


            if (selecteditem == "Spidol")
            {
                tb_harga.Text = "6000";
            }

            if (selecteditem == "Brush pen")
            {
                tb_harga.Text = "10000";
            }
        }
    }
}

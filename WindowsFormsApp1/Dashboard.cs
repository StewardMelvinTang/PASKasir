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
            txt_subtotal.Text = "0";
            txt_jumlah.Text = "0";
            txt_kembalian.Text = "0";
            txt_totalharga.Text = "Rp. 0";
            tb_items.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_hitung.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            tb_bayar.Text = "0";
            tb_jumlahbarang.Text = "0";
            cb_jenisbarang.Text = "None";
            tb_harga.Text = "0";
            txt_jumlah.Text = "0";
            txt_kembalian.Text = "0";
            txt_subtotal.Text = "0";
            txt_totalharga.Text = "Rp. 0";
            tb_items.Text = "";


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
            if (tb_harga.Text == null)
            {

            }
            else { update(); }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cb_jenisbarang_SelectedIndexChanged(object sender, EventArgs e)
        {

            update();
            String selecteditem = cb_jenisbarang.Text;


            if (selecteditem == "Kertas")
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

        private void updatesubtotal(int subtotal, int jumlahbarang)
        {

            int subjumlahbarang = 0;
            int subtotall = 0;
            int kembalian = 0;
            subtotall = Int32.Parse(txt_subtotal.Text);
            subjumlahbarang = Int32.Parse(txt_jumlah.Text);

            subjumlahbarang = jumlahbarang + subjumlahbarang;

            subtotall = subtotal + subtotall;
            txt_subtotal.Text = subtotall.ToString();
            txt_jumlah.Text = subjumlahbarang.ToString();
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {


            if (tb_harga.Text == "" || tb_jumlahbarang.Text == "" || tb_bayar.Text == "" || cb_jenisbarang.Text == "None" || tb_jumlahbarang.Text == "0")
            {

                MessageBox.Show("Silahkan isi data dengan benar");

            }
            else
            {


                int harga = Int32.Parse(tb_harga.Text);
                int jumlahbarang = Int32.Parse(tb_jumlahbarang.Text);
                int jumlahuang = Int32.Parse(tb_bayar.Text);




                int totalharga = harga * jumlahbarang;
                updatesubtotal(totalharga, jumlahbarang);



                int subtotal = Int32.Parse(txt_subtotal.Text);



                int jumlahharga = totalharga;
                txt_totalharga.Text = "Rp. " + jumlahharga.ToString();
                


                String lastitem = tb_items.Text;
                tb_items.Text = lastitem + "  " + cb_jenisbarang.Text + "," + jumlahbarang + "," + totalharga;

                int kembalian = jumlahuang - subtotal;
                txt_kembalian.Text = kembalian.ToString();


                if (kembalian < 0)
                {
                    MessageBox.Show("Duit pembeli kurang" + " Rp." + kembalian * -1);
                }
            }

        }

        private void tb_jumlahbarang_TextChanged(object sender, EventArgs e)
        {

            if (tb_jumlahbarang.Text == "")
            {

            }
            else
            {
                update();
            }




        }

        private void update()
        {

            if (tb_harga.Text == "" || tb_jumlahbarang.Text == "") { }
            else
            {
                int harga = Int32.Parse(tb_harga.Text);
                int jumlahbarang = Int32.Parse(tb_jumlahbarang.Text);

                int totalharga = harga * jumlahbarang;



                int jumlahharga = totalharga;
                txt_totalharga.Text = "Rp. " + jumlahharga;
            }

        }

        private void Kasirapp_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) e.Cancel = true;
        }
    }
    //end
}

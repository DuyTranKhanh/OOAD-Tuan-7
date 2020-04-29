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
    public partial class Form1 : Form
    {
        public static string username = "";
        public Form1()
        {
            InitializeComponent();
        }

        string err;
        BSLayer.BLDangNhap dbDN = new BSLayer.BLDangNhap();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thuc hien lenh
            BSLayer.BLDangNhap dangNhap = new BSLayer.BLDangNhap();
            if (dangNhap.Ktra(txtTK.Text.Trim(), txtPass.Text.Trim(), ref err) == true)
            {
                Form2 form2 = new Form2();
                username = txtTK.Text.Trim();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thong tin");
                txtTK.Clear();
                txtPass.Clear();
            }
        }

    }
}

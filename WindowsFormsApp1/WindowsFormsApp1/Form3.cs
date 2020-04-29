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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDungEntities enity = new QuanLyNguoiDungEntities();

            var user = enity.TaiKhoans.Where(u => u.Username == Form1.username && u.Password == textBox1.Text).FirstOrDefault();

            if (user != null)
            {
                user.Password = textBox2.Text;
                enity.SaveChanges();

                MessageBox.Show("Mật Khẩu thay đổi thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật Khẩu hiện tại không đúng");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

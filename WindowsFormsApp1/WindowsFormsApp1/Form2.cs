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
    public partial class Form2 : Form
    {
       // string err;
        BSLayer.BLDangNhap BLDangNhap = new BSLayer.BLDangNhap();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        //loaddata    
        private void Form2_Load(object sender, EventArgs e)
        {
            QuanLyNguoiDungEntities enity = new QuanLyNguoiDungEntities();

            string tenLoaiNguoiDung = (from taikhoan in enity.TaiKhoans
                                       join nguoidung in enity.NguoiDungs
                                       on taikhoan.IdNguoiDung equals nguoidung.IdNguoiDung
                                       join loainguoidung in enity.LoaiNguoiDungs
                                       on nguoidung.IdLoaiNguoiDung equals loainguoidung.IdLoaiNguoiDung
                                       where taikhoan.Username == Form1.username
                                       select loainguoidung.TenLoai).FirstOrDefault();
           
            var loaiNguoiDung = (from taikhoan in enity.TaiKhoans
                                  join nguoidung in enity.NguoiDungs
                                  on taikhoan.IdNguoiDung equals nguoidung.IdNguoiDung
                                  join loainguoidung in enity.LoaiNguoiDungs
                                  on nguoidung.IdLoaiNguoiDung equals loainguoidung.IdLoaiNguoiDung
                                  where taikhoan.Username == Form1.username
                                  select loainguoidung).FirstOrDefault();

           // List<Quyen> quyens = loaiNguoiDung.Quyens.ToList();

            textBox1.Text = tenLoaiNguoiDung;
            if (tenLoaiNguoiDung.Trim() == "G1")
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;

            }
            else if (tenLoaiNguoiDung.Trim() == "G2")
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = false;
                btn5.Enabled = false;
            }

            //MessageBox.Show(quyens.ToString());
        }
    }
}

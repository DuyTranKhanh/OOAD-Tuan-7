using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BSLayer
{
    class BLDangNhap
    {
        public bool Ktra(string username, string password, ref string err)
        {
            QuanLyNguoiDungEntities quanLyNguoiDungEntities = new QuanLyNguoiDungEntities();
            var u = (from tp in quanLyNguoiDungEntities.TaiKhoans
                     where tp.Username == username && tp.Password == password
                     select tp).SingleOrDefault();
            if (u != null)
                return true;
            else return false;

        }
        //lay id nguoi dung
        public int IdNguoiDung(string username, ref string err)
        {
            QuanLyNguoiDungEntities quanLyNguoiDungEntities = new QuanLyNguoiDungEntities();
            var u = (from tp in quanLyNguoiDungEntities.TaiKhoans
                     select tp).SingleOrDefault();

            if (u != null)
                return u.IdNguoiDung.Value;
            else return -1;
        }
        //co id nguoi dung 
        public int GetidLoaiNguoiDung(int idnguoidung, ref string err)
        {
            QuanLyNguoiDungEntities quanLyNguoiDungEntities = new QuanLyNguoiDungEntities();
            var u = (from a in quanLyNguoiDungEntities.NguoiDungs
                     from b in quanLyNguoiDungEntities.LoaiNguoiDungs
                     where b.IdLoaiNguoiDung == a.IdLoaiNguoiDung && a.IdNguoiDung == idnguoidung
                     select b).SingleOrDefault();
            if (u != null)
                return u.IdLoaiNguoiDung;
            else return -1;

        }
    }
}

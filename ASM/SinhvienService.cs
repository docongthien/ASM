using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    public class SinhvienService
    {
        public List<Sinhvien> sinhViens = new List<Sinhvien>();

        public void AddSinhVien(Sinhvien sinhVien)
        {
            if (string.IsNullOrEmpty(sinhVien.TenLop) || sinhVien.TenLop.Any(ch => !char.IsLetterOrDigit(ch) && ch != ' '))
            {
                throw new ArgumentException("Tên lớp không được chứa ký tự đặc biệt.");
            }
            if (string.IsNullOrEmpty(sinhVien.MaSV) || !sinhVien.MaSV.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Mã sinh viên không hợp lệ.");
            }

            if (sinhViens.Any(sv => sv.MaSV == sinhVien.MaSV))
            {
                throw new ArgumentException("Mã sinh viên không được trùng lặp.");
            }

            if (sinhVien.TenLop.Any(ch => !Char.IsLetterOrDigit(ch) && ch != ' '))
            {
                throw new ArgumentException("Tên lớp không được chứa ký tự đặc biệt.");
            }

            if (string.IsNullOrEmpty(sinhVien.HoTen))
            {
                throw new ArgumentException("Tên sinh viên không được để trống");
            }
            if ( !(sinhVien.HoTen.Length  >= 5 && sinhVien.HoTen.Length <= 15) ) 
            {
                throw new ArgumentException("Tên thuộc khoảng từ 5-15");
            }
            sinhViens.Add(sinhVien);
        }

        public List<Sinhvien> TimKiemMaSv(string masv)
        {
            
            var sinhvien = sinhViens.Where(sv => sv.MaSV.Contains(masv)).ToList();
            if(!sinhvien.Any())
            {
                throw new ArgumentException("Không tìm thấy sinh viên");
            }
            else
            {
                return sinhvien;
            }
        }
    }
}

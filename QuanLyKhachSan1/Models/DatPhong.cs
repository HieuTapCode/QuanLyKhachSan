using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan1.Models
{
    public class Datphong
    {
       // Thông tin đặt phòng
        public DateTime NgayDat { get; set; }
        public DateTime NgayTra { get; set; }
        public string LoaiPhong { get; set; } 
        public decimal GiamTru { get; set; } 
        public string PhuongThucThanhToan { get; set; }
        public decimal TienTraLai { get; set; }

        // Danh sách khách
        public List<Khach> DanhSachKhach { get; set; }

        // Danh sách phòng
        public List<Phong> DanhSachPhong { get; set; }

        // Hàm khởi tạo
        
        
    }

    public class Khach
    {
        public int STT { get; set; }
        public string TenKhachHang { get; set; }
        public string CCCD { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Phong { get; set; }
    }

    public class Phong
    {
        public int STT { get; set; }
        public string TenPhong { get; set; }
        public string LoaiPhong { get; set; }
        public int NguoiLon { get; set; }
        public int TreEm { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
    }
}
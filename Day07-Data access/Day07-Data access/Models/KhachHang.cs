using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class KhachHang
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được để trống")]
        [StringLength(20, ErrorMessage = "Mã khách hàng tối đa 20 ký tự")]
        public string? MaKhachHang { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(100, ErrorMessage = "Họ tên tối đa 100 ký tự")]
        public string? HoTenKhachHang { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 ký tự trở lên")]
        public string? MaKhau { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0")]
        public string? DienThoai { get; set; }

        public string? DiaChi { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public byte? TrangThai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    }
}

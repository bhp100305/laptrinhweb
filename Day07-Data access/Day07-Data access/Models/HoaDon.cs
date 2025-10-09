using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class HoaDon
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã hóa đơn không được để trống")]
        [StringLength(20, ErrorMessage = "Mã hóa đơn tối đa 20 ký tự")]
        public string? MaHoaDon { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn khách hàng")]
        public int? MaKhaHang { get; set; }

        [Required(ErrorMessage = "Ngày hóa đơn không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgayHoaDon { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày nhận hàng")]
        public DateTime? NgayNhan { get; set; }

        [Required(ErrorMessage = "Họ tên khách hàng không được để trống")]
        [StringLength(100, ErrorMessage = "Họ tên tối đa 100 ký tự")]
        [Display(Name = "Họ tên khách hàng")]
        public string? HoTenKhachHang { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [StringLength(15)]
        [Display(Name = "Điện thoại")]
        public string? DienThoai { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(200, ErrorMessage = "Địa chỉ tối đa 200 ký tự")]
        [Display(Name = "Địa chỉ giao hàng")]
        public string? DiaChi { get; set; }

        [Required(ErrorMessage = "Tổng trị giá không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Tổng trị giá phải lớn hơn 0")]
        [Display(Name = "Tổng trị giá (VNĐ)")]
        public double? TongTriGia { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [Range(0, 1, ErrorMessage = "Trạng thái chỉ nhận 0 (chưa giao) hoặc 1 (đã giao)")]
        public byte? TrangThai { get; set; }

        // 🔗 Navigation Properties
        [Display(Name = "Chi tiết hóa đơn")]
        public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();

        [Display(Name = "Khách hàng")]
        public virtual KhachHang? MaKhaHangNavigation { get; set; }
    }
}

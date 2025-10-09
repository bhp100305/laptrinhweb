using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class CtHoaDon
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn hóa đơn")]
        public int? HoaDonId { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn sản phẩm")]
        public int? SanPhamId { get; set; }

        [Required(ErrorMessage = "Số lượng mua không được để trống")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng mua phải lớn hơn 0")]
        public int? SoLuongMua { get; set; }

        [Required(ErrorMessage = "Đơn giá mua không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Đơn giá mua phải lớn hơn 0")]
        public double? DonGiaMua { get; set; }

        [Required(ErrorMessage = "Thành tiền không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Thành tiền phải lớn hơn 0")]
        public double? ThanhTien { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [Range(0, 1, ErrorMessage = "Trạng thái chỉ nhận giá trị 0 (ẩn) hoặc 1 (hiển thị)")]
        public byte? TrangThai { get; set; }

        public virtual HoaDon? HoaDon { get; set; }

        public virtual SanPham? SanPham { get; set; }
    }
}

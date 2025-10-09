using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class SanPham
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        [StringLength(50, ErrorMessage = "Mã sản phẩm tối đa 50 ký tự")]
        [Display(Name = "Mã sản phẩm")]
        public string? MaSanPham { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(255, ErrorMessage = "Tên sản phẩm tối đa 255 ký tự")]
        [Display(Name = "Tên sản phẩm")]
        public string? TenSanPham { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(255)]
        public string? HinhAnh { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống")]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải là số không âm")]
        [Display(Name = "Số lượng tồn kho")]
        public int? SoLuong { get; set; }

        [Required(ErrorMessage = "Đơn giá không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn hoặc bằng 0")]
        [Display(Name = "Đơn giá (VNĐ)")]
        public double? DonGia { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm")]
        [Display(Name = "Loại sản phẩm")]
        public int? MaLoai { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [Range(0, 1, ErrorMessage = "Trạng thái chỉ nhận 0 (ẩn) hoặc 1 (hiển thị)")]
        [Display(Name = "Trạng thái")]
        public byte? TrangThai { get; set; }

        // 🔗 Navigation properties
        public virtual ICollection<CtHoaDon> CtHoaDons { get; set; } = new List<CtHoaDon>();

        [Display(Name = "Loại sản phẩm")]
        public virtual LoaiSanPham? MaLoaiNavigation { get; set; }
    }
}

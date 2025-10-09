using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class LoaiSanPham
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã loại không được để trống")]
        [StringLength(50, ErrorMessage = "Mã loại tối đa 50 ký tự")]
        [Display(Name = "Mã loại sản phẩm")]
        public string? MaLoai { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không được để trống")]
        [StringLength(100, ErrorMessage = "Tên loại tối đa 100 ký tự")]
        [Display(Name = "Tên loại sản phẩm")]
        public string? TenLoai { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [Range(0, 1, ErrorMessage = "Trạng thái chỉ nhận 0 (Ẩn) hoặc 1 (Hiển thị)")]
        [Display(Name = "Trạng thái")]
        public byte? TrangThai { get; set; }

        // 🔗 Navigation property (quan hệ 1-n)
        [Display(Name = "Danh sách sản phẩm")]
        public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
    }
}

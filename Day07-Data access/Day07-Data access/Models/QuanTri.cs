using System;
using System.ComponentModel.DataAnnotations;

namespace Day07_Data_access.Models
{
    public partial class QuanTri
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(25, ErrorMessage = "Tài khoản tối đa 25 ký tự")]
        [Display(Name = "Tài khoản")]
        public string? TaiKhoan { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(255, ErrorMessage = "Mật khẩu tối đa 255 ký tự")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string? MatKhau { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống")]
        [Range(0, 1, ErrorMessage = "Trạng thái chỉ nhận 0 (khóa) hoặc 1 (hoạt động)")]
        [Display(Name = "Trạng thái")]
        public byte? TrangThai { get; set; }
    }
}

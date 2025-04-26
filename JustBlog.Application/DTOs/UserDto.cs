using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tên người dùng không được để trống.")]
        [StringLength(256, ErrorMessage = "Tên người dùng không vượt quá {1} ký tự.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Range(18,100, ErrorMessage = "Tuổi phải từ {1} đến {2}.")]
        public int? Age { get; set; }

        [StringLength(1000, ErrorMessage = "Thông tin cá nhân không vượt quá {1} ký tự.")]
        public string AboutMe { get; set; }

        [Required(ErrorMessage = "Ngày đăng ký không được để trống.")]
        public DateTime RegisteredOn { get; set; }
    }
}

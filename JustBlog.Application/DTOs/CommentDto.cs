using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.DTOs
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên không vượt quá {1} ký tự.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nội dung bình luận không được để trống.")]
        [StringLength(1000, ErrorMessage = "Nội dung không vượt quá {1} ký tự.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Thời gian bình luận không được để trống.")]
        public DateTime CommentedOn { get; set; }

        [Required(ErrorMessage = "Bài viết không được để trống.")]
        public Guid PostId { get; set; } // Tham chiếu đến Post
    }
}

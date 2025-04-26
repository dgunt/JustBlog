using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.DTOs
{
    public class PostDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống.")]
        [StringLength(500, ErrorMessage = "Tiêu đề không vượt quá {1} ký tự.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mô tả ngắn không được để trống.")]
        [StringLength(1000, ErrorMessage = "Mô tả ngắn không vượt quá {1} ký tự.")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Ngày đăng không được để trống.")]
        public DateTime PostedOn { get; set; }

        [Required(ErrorMessage = "URL thân thiện không được để trống.")]
        [StringLength(200, ErrorMessage = "URL thân thiện không vượt quá {1} ký tự.")]
        public string UrlSlug { get; set; }

        public bool Published { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượt xem không hợp lệ.")]
        public int ViewCount { get; set; }

        // Thông tin liên quan đến Category
        [Required(ErrorMessage = "Danh mục không được để trống.")]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Danh sách Tag (chỉ lấy Id và Name)
        public List<TagDto> Tags { get; set; } = new List<TagDto>();
    }
}

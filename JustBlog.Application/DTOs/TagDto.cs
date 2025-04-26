using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.DTOs
{
    public class TagDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên thẻ không được để trống.")]
        [StringLength(100, ErrorMessage = "Tên thẻ không vượt quá {1} ký tự.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "URL thân thiện không được để trống.")]
        [StringLength(200, ErrorMessage = "URL thân thiện không vượt quá {1} ký tự.")]
        public string UrlSlug { get; set; }

        [StringLength(1000, ErrorMessage = "Mô tả không vượt quá {1} ký tự.")]
        public string Description { get; set; }
    }
}

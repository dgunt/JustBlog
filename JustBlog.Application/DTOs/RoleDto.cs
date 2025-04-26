using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.DTOs
{
    public class RoleDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tên vai trò không được để trống.")]
        [StringLength(256, ErrorMessage = "Tên vai trò không vượt quá {1} ký tự.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Mô tả không vượt quá {1} ký tự.")]
        public string Description { get; set; }
    }
}

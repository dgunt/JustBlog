using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class Tag
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Sử dụng Guid làm khóa chính
        public string Name { get; set; }               // Tên thẻ (ví dụ: "C#", "ASP.NET Core")
        public string UrlSlug { get; set; }            // URL thân thiện (ví dụ: "csharp")
        public string Description { get; set; }        // Mô tả thẻ (tùy chọn)

        // Quan hệ nhiều-nhiều với Post
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}

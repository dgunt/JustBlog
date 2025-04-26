using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string ShortDescription { get; set; } // Mô tả ngắn
        public string Content { get; set; } // Nội dung bài viết
        public string UrlSlug { get; set; } // URL thân thiện SEO
        public DateTime PostedOn { get; set; } // Ngày đăng
        public DateTime? Modified { get; set; } // Ngày sửa (có thể null)
        public bool Published { get; set; } // Trạng thái công khai
        public int ViewCount { get; set; } // Lượt xem
        public int RateCount { get; set; } // Lượt đánh giá
        public decimal TotalRate { get; set; } // Tổng điểm đánh giá

        // Khóa ngoại và Navigation Properties
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } // Danh mục bài viết
        public ICollection<Tag> Tags { get; set; } = new List<Tag>(); // Danh sách thẻ
        public ICollection<Comment> Comments { get; set; } = new List<Comment>(); // Bình luận
    }
}

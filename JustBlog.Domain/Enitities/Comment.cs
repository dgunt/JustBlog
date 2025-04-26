using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime CommentedOn { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}

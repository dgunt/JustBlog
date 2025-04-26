using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}

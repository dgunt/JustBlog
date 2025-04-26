using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class User: IdentityUser<Guid>
    {
        public string FullName { get; set; } // Tên đầy đủ
        public int Age { get; set; } // Tuổi
        public string AboutMe { get; set; } // Thông tin cá nhân
        public DateTime RegisteredOn { get; set; } // Ngày đăng ký
    }
}

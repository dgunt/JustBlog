﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Domain.Enitities
{
    public class Role: IdentityRole<Guid>
    {
        public string Description { get; set; } // Mô tả vai trò
    }
}

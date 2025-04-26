using AutoMapper;
using JustBlog.Application.DTOs;
using JustBlog.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map Post → PostDto
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name)) // Lấy tên Category
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags)); // Map danh sách Tag

            // Map Category → CategoryDto
            CreateMap<Category, CategoryDto>();

            // Map Tag → TagDto
            CreateMap<Tag, TagDto>();

            // Map Comment → CommentDto
            CreateMap<Comment, CommentDto>();

            // Map User → UserDto
            CreateMap<User, UserDto>();

            // Map Role → RoleDto
            CreateMap<Role, RoleDto>();

            // Reverse Map (nếu cần update từ DTO → Entity)
            CreateMap<PostDto, Post>();
            CreateMap<CategoryDto, Category>();
            CreateMap<TagDto, Tag>();
            CreateMap<CommentDto, Comment>();
            CreateMap<UserDto, User>();
            CreateMap<RoleDto, Role>();
        }
    }
}

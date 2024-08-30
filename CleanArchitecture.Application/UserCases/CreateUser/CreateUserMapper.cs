using AutoMapper;
using CleanArchitecture.Application.UserCases.CreatUser;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UserCases.CreateUser
{
    public sealed class CreateUserMapper : Profile
    {
        public CreateUserMapper() 
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}

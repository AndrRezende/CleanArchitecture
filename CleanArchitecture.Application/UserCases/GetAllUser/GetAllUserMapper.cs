using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UserCases.GetAllUser;

public sealed class GetAllUserMapper : Profile
{
    public GetAllUserMapper() 
    {
        CreateMap<User, GetAllUserResponse>();
    }
}

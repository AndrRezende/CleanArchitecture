using CleanArchitecture.Application.UseCases.GetAllUser;
using MediatR;

namespace CleanArchitecture.Application.UseCases.GetAllUser;

public sealed record GetAllUserRequest :
                   IRequest<List<GetAllUserResponse>>;
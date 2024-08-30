using CleanArchitecture.Application.UserCases.CreatUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UserCases.CreateUser;

public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
{
    //Regras para inserir email e nome
    public CreateUserValidator() 
    {
        RuleFor(X => X.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(X => X.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}

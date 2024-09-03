using FluentValidation;

namespace CleanArchitecture.Application.UserCases.GetAllUser
{
    public class GetAllUserValidator : AbstractValidator<GetAllUserRequest>
    {
        public GetAllUserValidator() 
        {
            //sem validação
        }
    }
}

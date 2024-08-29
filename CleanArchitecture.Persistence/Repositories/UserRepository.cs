
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

// Repositório específico para operações relacionadas à entidade "User"
public class UserRepository : BaseRepository<User>, IUserRepository
{
    // Construtor que recebe o contexto do banco de dados e o passa para a classe base (BaseRepository)
    public UserRepository(AppDbContext context) : base(context)
    { }

    // Método assíncrono para buscar um usuário pelo e-mail
    public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
    {
        // Procura o primeiro usuário que corresponde ao e-mail fornecido
        return await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
    }
}


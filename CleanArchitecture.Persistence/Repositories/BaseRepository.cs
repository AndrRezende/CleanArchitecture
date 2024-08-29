using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories
{
    // Implementação de um repositório genérico para operações CRUD usando Entity Framework
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        // Contexto do banco de dados que será utilizado para acessar as tabelas
        protected readonly AppDbContext Context;

        // Construtor que inicializa o contexto do banco de dados
        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }

        // Método para criar um novo registro da entidade T no banco de dados
        public void Create(T entity)
        {
            // Define a data de criação como o momento atual
            entity.DateCreated = DateTimeOffset.UtcNow;
            // Adiciona a entidade ao contexto para ser inserida no banco
            Context.Add(entity);
        }

        // Método para atualizar um registro existente da entidade T no banco de dados
        public void Update(T entity)
        {
            // Define a data de atualização como o momento atual
            entity.DateUpdated = DateTimeOffset.UtcNow;
            // Marca a entidade como modificada no contexto
            Context.Update(entity);
        }

        // Método para deletar um registro da entidade T no banco de dados
        public void Delete(T entity)
        {
            // Define a data de exclusão como o momento atual
            entity.DateDeleted = DateTimeOffset.UtcNow;
            // Remove a entidade do contexto
            Context.Remove(entity);
        }

        // Método assíncrono para obter um registro da entidade T pelo seu ID
        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            // Procura o primeiro registro que corresponde ao ID fornecido
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        // Método assíncrono para obter todos os registros da entidade T
        public async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            // Retorna todos os registros da entidade T como uma lista
            return await Context.Set<T>().ToListAsync(cancellationToken);
        }
    }
}

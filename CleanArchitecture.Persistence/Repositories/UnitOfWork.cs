
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

// Classe que implementa o padrão Unit of Work, responsável por coordenar as operações de persistência
public class UnitOfWork : IUnitOfWork
{
    // Contexto do banco de dados utilizado para realizar as operações de CRUD
    private readonly AppDbContext _context;

    // Construtor da classe, recebe uma instância do contexto do banco de dados e a armazena em um campo privado
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    // Método responsável por confirmar (commit) todas as mudanças realizadas no contexto do banco de dados
    public async Task Commit(CancellationToken cancellationToken)
    {
        // Salva todas as mudanças pendentes no banco de dados de forma assíncrona
        await _context.SaveChangesAsync(cancellationToken);
    }
}

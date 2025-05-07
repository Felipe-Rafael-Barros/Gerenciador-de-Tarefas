using Microsoft.EntityFrameworkCore;
using GerenciadorDeTarefas.models;

namespace GerenciadorDeTarefas.data
{
    public class AppDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração do banco de dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Propriedades que representam as tabelas no banco de dados
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}

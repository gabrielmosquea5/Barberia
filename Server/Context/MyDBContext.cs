using Microsoft.EntityFrameworkCore;
using Barberia.Server.Models;

 namespace Barberia.Server.Context;

public interface IMyDbContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    //Constructor de la clase 
    protected readonly IConfiguration configuration;
    public MyDbContext(IConfiguration _configuration)
    {
        configuration = _configuration;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("Barberia"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de mi base de datos
    public DbSet<UsuarioRol> UsuariosRoles { set; get; } = null!;

    public DbSet<Usuario> Usuarios { set; get; } = null!;
    #region
}
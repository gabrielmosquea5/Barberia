using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Barberia.Server.Models;

 namespace Barberia.Server.Context;

public interface IMyDbContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

internal class MyDbContext : DbContext, IMyDbContext
{
    //Constructor de la clase 
    protected readonly IConfiguration _configuration;
    public MyDbContext(IConfiguration configuration) 
    { 
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(_configuration.GetConnectionString("Barberia"));
    }
    #region Tablas de la BD.
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<UsuarioRol> UsuariosRoles { get; set; } = null!;
    #endregion
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}
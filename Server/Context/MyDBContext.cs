using Microsoft.EntityFrameworkCore;
using BARBERIA.Server.Models;

 namespace BARBERIA.Server.Context;

 internal interface IMyDbContext
{
    DbSet<Usuario> Usuarios { get; set; }
    DbSet<UsuarioRol> UsuariosRoles { get; set; }

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
        options.UseSqlServer(_configuration.GetConnectionString("DbBarberia"));
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
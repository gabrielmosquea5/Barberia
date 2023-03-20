
using Ardalis.ApiEndpoints;
using Barberia.Server.Context;
using Barberia.Server.Models;
using Barberia.Shared.Records;
using Barberia.Shared.Routes;
using Barberia.Shared.Routes.Wrapper;
using Barberia.Shared.Wrapper;
using BARBERIA.Server.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barberia.Server.Endpoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Get(IMyDbContext dbContext) => this.dbContext = dbContext;
    [HttpGet(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {
       try
       {
        var roles = await dbContext.UsuariosRoles
       .Select(rol=>rol.ToRecord())
       .ToListAsync(cancellationToken);

       return Respuesta.Success(roles);
       }
       catch(Exception ex)
       {
        return Respuesta.Fail(ex.Message);
       }
    }
}


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
using Respuesta = Result<UsuarioRolRecord>;
using Request = UsuarioRolRouteManager;

public class GetById : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public GetById (IMyDbContext dbContext) => this.dbContext = dbContext;
    [HttpGet(UsuarioRolRouteManager.GetById)]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute]CancellationToken cancellationToken = default)
    {
       try
       {
        var roles = await dbContext.UsuariosRoles
        .Where(r=>r.Id == Request.Id)
       .Select(rol=>rol.ToRecord())
       .FirstOrDefaultAsync(cancellationToken);
       if(roles==null)
       return Respuesta.Fail($"No fue posible encontrar el rol'{request.Id}'");

       return Respuesta.Success(rol);
       }
       catch(Exception ex)
       {
        return Respuesta.Fail(ex.Message);
       }
    }
}

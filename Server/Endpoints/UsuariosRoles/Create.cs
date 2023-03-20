using System.Security.Cryptography;
using Ardalis.ApiEndpoints;
using Barberia.Shared;
using Barberia.Server.Context; 
using Barberia.Shared.Records;
using Barberia.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using BARBERIA.Server.Models;
using Barberia.Shared.Routes;

namespace Barberia.Server.Endpoints.UsuariosRoles;

using Request = UsuarioRolRecordCreateRequest;
using Respuesta = Result<int>;

public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContex dbContex;

    public Create(IMyDbContex dbContex)
    {
        this.dbContex = dbContex;
    }
    [HttpPost(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(UsuarioRolRecordCreateRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            #region Validaciones 
            var rol = await dbContex.UsuariosRoles.FirstOrDefaoltAsync(r=> r.Nobre.Tolower() == request.Nombre.Tolower(),cancellationToken);
            if(rol != null)
            retura Respuesta.Fail($"Ya existe un rol con el nombre'({request.Nombre})'.");
            #endregion
            rol = UsuarioRol.Crear(request);
            dbContext.UsuaruosRoles.Add(rol);
            await dbContext.saveChangesAsyn(cancellationToken);
            return Respuesta.Success(rol.Id)
        }
        catch(Exception e){
            return Respuesta.Fail(e.Message)
        }
    }
}
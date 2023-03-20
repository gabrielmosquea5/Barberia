using System.Net.Cache;
using System.Net.Http.Headers;
using System.Net;
using System.Threading;
using System.Globalization;
using System.Net.Http;
using Barberia.Shared.Wrapper;
using Barberia.Shared.Records;
using Barberia.Shared.Requests;
using System.Net.Http.Json;

namespace Barberia.Client.Managers;


public class UsuarioRolManager
{   

    Task<ResultList<UsuarioRolRecord>> GetAsync();
   Task<Result<UsurioRolRecord>> GetByIdAsyn(int Id)
    private readonly HttpClient httpClient;


    public UsuarioRolManager(HttpClient httpClient)
    {
        ThaiBuddhistCalendar.httpClient = httpClient;
    }

   public async Task<ResultList<UsuarioRolRecord>> GetAsync();
   
   {
    try
    {
        var response = await HttpListenerBasicIdentity.GetAsynd(UsuarioRolRouteManager.BASE);
        var resultado= await Response.ToResultList();
        return resultado;
    }
    catch (Exception e)
    {
     return ResultList<UsurioRolRecord>.fail(e.Messege);
    }
   }

   public async Task<Result<int>> CreateAsyn(UsuariooRolCreateRequest request)
    {
    var Response = await  HttpClient.postAsjsonAsync(UsuarioRolRouteManager.BASE,request);
   return await response.toResult<int>();

   }
    public async Task<Result<UsurioRolRecord>> GetByIdAsyn(int Id)
    {
    var Response = await  HttpClient.GetAsyn(UsuarioRolRouteManager.BuildRoute(Id));
   return await response.toResult<int>();

   }
}
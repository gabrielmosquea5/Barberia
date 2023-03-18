using System.Net;
using Barberia.Shared.Wrapper;
using Newtonsoft.Json;



namespace Barberia.Client.Extensions;
 internal static class ResultExtension 

 {

    internal static async Task<Result>> ToResult<t>(this HttpResponsemessage response)

    {
        var respuesta_a_texto = await response.content.ReadAsStringAsync();  
       var objeto = JsonConvert.DeserializeObject<Result<T>>(respuesta_a_texto );
       return objeto;
        
    }



    internal static async Task<ResultList>> ToResultList<t>(this HttpResponsemessage response)

    {
        var respuesta_a_texto = await response.content.ReadAsStringAsync();  
       var objeto =JsonConvert.DeserializeObject<ResultLlist<T>>(Respuesta_a_texto );
       return objeto;
        
    }

 }

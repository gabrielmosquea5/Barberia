
using System.ComponentModel.DataAnnotations;

namespace Barberia.Served.Requests;

public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest 
{
     [Required(ErrorMessage = "Se debe proporcionar el Id del usuario a modificar.")]
    public int Id { get; set; } 

}


namespace BARBERIA.Shared.Requests;

public class UsuarioRequest
{
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Correo { get; set; } = null!;
    public string Contrasena { get; set; } = null!;
}
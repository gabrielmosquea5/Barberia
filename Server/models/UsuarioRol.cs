using System.ComponentModel.DataAnnotations;

namespace BARBERIA.Server.Models;

public class UsuarioRol
{
    [Key]
    public int Id { get; set; }
    public string RNombre { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar { get; set; }
    public bool PermisoParaCEliminar { get; set; }
    public virtual ICollection<UsuarioRol>? Usuarios { get; set; }
}

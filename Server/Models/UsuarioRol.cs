using System;
using System.ComponentModel.DataAnnotations;




namespace Barberia.Server.Models;

public class UsuarioRol

{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar{ get; set; }
    public bool PermisoParaEliminar{ get; set; }
}


public class Usuario 
{
    [Key]
     public int Id { get; set; }
      public int UsuariorolId { get; set; }
        public virtual UsuariorolId UsuariorolId { get; set; } = null!;
        public string Name  { get; set; } = null!;
        public string Nickname  { get; set; } = null!;
        public string Password  { get; set; } = null!;
        


}
{




}
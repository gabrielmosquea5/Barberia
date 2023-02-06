using System.ComponentModel.DataAnnotations;
using BARBERIA.Shared.Requests;


namespace BARBERIA.Server.Models;


public class Usuario

{
    [Key]
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public UsuarioRol UsuarioRol { get; set; } = default!;
    public string Nombre { get; set; } = null!;
    public string Correo { get; set; } = null!;
    public string Contrasena { get; set; } = null!;

    public static Usuario Crear(UsuarioRequest request) 
    {
        return new Usuario()
        {
            UsuarioRolId = request.UsuarioRolId,
            Nombre = request.Nombre,
            Correo = request.Correo,
            Contrasena = request.Contrasena
        };
    }
    public void editar (UsuarioRequest request)
    {
        UsuarioRolId = request.UsuarioRolId;
        Nombre = request.Nombre;
        Correo = request.Correo;
        //Contrasena = request.Contrasena;
    }
}

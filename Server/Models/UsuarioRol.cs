using System;
using System.ComponentModel.DataAnnotations;
using Barberia.Served.Requests;
using Barberia.Shared.Records;

namespace BARBERIA.Server.Models; 

public  class UsuarioRol

{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar{ get; set; }
    public bool PermisoParaEliminar{ get; set; }

    public static UsuarioRol Crear(UsuarioRolCreateRequest request)
    {
        return new UsuarioRol(){ 
            Nombre = request.Nombre,
            PermisoParaCrear = request.PermisoParaCrear, 
            PermisoParaEditar = request.PermisoParaEditar, 
            PermisoParaEliminar = request.PermisoParaEliminar, 
            };
    }

     public void Modificar(UsuarioRolUpdateRequest request){
        if(Nombre != request.Nombre)
            Nombre = request.Nombre;
        if(PermisoParaCrear!= request.PermisoParaCrear)
            PermisoParaCrear = request.PermisoParaCrear;
        if(PermisoParaEditar!=request.PermisoParaEditar)
            PermisoParaEditar = request.PermisoParaEditar;
        if(PermisoParaEliminar!=request.PermisoParaEliminar)
            PermisoParaEliminar = request.PermisoParaEliminar;
    }
    
    public static Usuari
    oRolRecord Torecord()
     {
        return new UsuarioRolRecord(Id,Nombre,PermisoParaCrear,PermisoParaEditar,PermisoParaEliminar);
     }
  

}


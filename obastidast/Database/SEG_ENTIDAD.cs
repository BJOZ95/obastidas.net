//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace obastidast.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class SEG_ENTIDAD
    {
        public int SEG_ENTIDAD_Id { get; set; }
        public int EMP_Id_Empresa { get; set; }
        public int ENT_Id_Entidad { get; set; }
        public string ENT_Nombre { get; set; }
        public string ENT_Apellido { get; set; }
        public string ENT_Ced_Ruc { get; set; }
        public string ENT_Est_Civil { get; set; }
        public string ENT_Titulo { get; set; }
        public string ENT_Sexo { get; set; }
        public string ENT_Persona { get; set; }
        public string ENT_Direccion { get; set; }
        public string ENT_Telefono { get; set; }
        public string ENT_Fax { get; set; }
        public string ENT_Email { get; set; }
        public string PAI_Continente { get; set; }
        public int PAI_Id_Pais { get; set; }
        public int PRO_Id_Provin { get; set; }
        public int CIU_Id_Ciudad { get; set; }
        public string ENT_Descripcion { get; set; }
        public string ENT_Estado { get; set; }
        public Nullable<int> Aud_EstadoAI_Id { get; set; }
        public Nullable<int> Aud_Usuario_Ingreso { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Ingreso { get; set; }
        public string Aud_PC_Ingreso { get; set; }
        public Nullable<int> Aud_Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Modifica { get; set; }
        public string Aud_PC_Modifica { get; set; }
    
        public virtual SEG_EMPRESA SEG_EMPRESA { get; set; }
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO1 { get; set; }
    }
}

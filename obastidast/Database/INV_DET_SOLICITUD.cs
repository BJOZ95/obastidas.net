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
    
    public partial class INV_DET_SOLICITUD
    {
        public int SOL_Id_Solicitud_Det { get; set; }
        public int EMP_Id_Empresa { get; set; }
        public string SOL_Solicitud_Id { get; set; }
        public int SOL_Sec { get; set; }
        public int ART_Id_Articulos { get; set; }
        public string SOL_Descripcion { get; set; }
        public int SOL_Cantidad { get; set; }
        public int SOL_Tiempo_Espera { get; set; }
        public Nullable<int> SOL_Pendiente { get; set; }
        public Nullable<int> SOL_Orden { get; set; }
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

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
    
    public partial class SEG_CAB_PURGA
    {
        public int SEG_CAB_PURGA_Id { get; set; }
        public int EMP_Id_Empresa { get; set; }
        public int CAB_Id_Purga { get; set; }
        public string USU_Login { get; set; }
        public System.DateTime CAB_Fecha { get; set; }
        public string CAB_Tabla { get; set; }
        public string CAB_Modulo { get; set; }
        public string USU_Elim { get; set; }
        public System.DateTime USU_Fecelim { get; set; }
        public string USU_Con { get; set; }
        public System.DateTime USU_Feccon { get; set; }
        public string USU_Rep { get; set; }
        public System.DateTime USU_Fecrep { get; set; }
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

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
    
    public partial class CON_DIARIO_SECUENCIA
    {
        public int Con_CompSec_Id { get; set; }
        public int Gen_PrmAnio_Id { get; set; }
        public int Gen_PrmMes_Id { get; set; }
        public int SEG_EMPRESA_Id { get; set; }
        public int Con_CompTip_Id { get; set; }
        public int Con_CompSec_Numero { get; set; }
        public Nullable<int> Aud_EstadoAI_Id { get; set; }
        public Nullable<int> Aud_Usuario_Ingreso { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Ingreso { get; set; }
        public string Aud_PC_Ingreso { get; set; }
        public Nullable<int> Aud_Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Modifica { get; set; }
        public string Aud_PC_Modifica { get; set; }
    
        public virtual GEN_ANIO GEN_ANIO { get; set; }
        public virtual SEG_EMPRESA SEG_EMPRESA { get; set; }
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
        public virtual GEN_MES GEN_MES { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO1 { get; set; }
        public virtual CON_DIARIO_TIPO CON_DIARIO_TIPO { get; set; }
    }
}
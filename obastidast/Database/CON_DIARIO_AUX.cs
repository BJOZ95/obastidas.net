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
    
    public partial class CON_DIARIO_AUX
    {
        public int Con_DiarioAux_Id { get; set; }
        public int SEG_EMPRESA_Id { get; set; }
        public int Con_DiarioCab_Id { get; set; }
        public int Con_DiarioDet_Id { get; set; }
        public int Con_AuxTipo_Id { get; set; }
        public string Con_DiarioAux_Codigo { get; set; }
        public string Con_DiarioAux_Nombre { get; set; }
        public int Con_CCos_Id { get; set; }
        public string Con_DiarioAux_Glosa { get; set; }
        public decimal Con_DiarioAux_Total { get; set; }
        public Nullable<int> Aud_EstadoAI_Id { get; set; }
        public Nullable<int> Aud_Usuario_Ingreso { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Ingreso { get; set; }
        public string Aud_PC_Ingreso { get; set; }
        public Nullable<int> Aud_Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Modifica { get; set; }
        public string Aud_PC_Modifica { get; set; }
    
        public virtual CON_CENTRO_COSTOS CON_CENTRO_COSTOS { get; set; }
        public virtual CON_DIARIO_AUX_TIPO CON_DIARIO_AUX_TIPO { get; set; }
        public virtual CON_DIARIO_CAB CON_DIARIO_CAB { get; set; }
        public virtual CON_DIARIO_DET CON_DIARIO_DET { get; set; }
        public virtual SEG_EMPRESA SEG_EMPRESA { get; set; }
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO1 { get; set; }
    }
}

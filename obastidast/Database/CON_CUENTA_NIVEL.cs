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
    
    public partial class CON_CUENTA_NIVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CON_CUENTA_NIVEL()
        {
            this.CON_CUENTA_PLAN = new HashSet<CON_CUENTA_PLAN>();
        }
    
        public int Con_NivCta_Id { get; set; }
        public int Con_NivCta_Nivel { get; set; }
        public string Con_NivCta_Descripcion { get; set; }
        public int Con_NivCta_Cant_Caracter { get; set; }
        public int Con_NivCta_Separador_SN { get; set; }
        public string Con_NivCta_Separador_Caracter { get; set; }
        public Nullable<int> Aud_EstadoAI_Id { get; set; }
        public Nullable<int> Aud_Usuario_Ingreso { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Ingreso { get; set; }
        public string Aud_PC_Ingreso { get; set; }
        public Nullable<int> Aud_Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Modifica { get; set; }
        public string Aud_PC_Modifica { get; set; }
    
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO1 { get; set; }
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_CUENTA_PLAN> CON_CUENTA_PLAN { get; set; }
    }
}

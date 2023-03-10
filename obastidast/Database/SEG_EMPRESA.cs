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
    
    public partial class SEG_EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEG_EMPRESA()
        {
            this.BCO_CUENTA_BANCOS = new HashSet<BCO_CUENTA_BANCOS>();
            this.Clases_Tipos = new HashSet<Clases_Tipos>();
            this.COM_CAB_DEV = new HashSet<COM_CAB_DEV>();
            this.COM_CAB_ORDEN = new HashSet<COM_CAB_ORDEN>();
            this.COM_CATEGORIA_PROVEEDORES = new HashSet<COM_CATEGORIA_PROVEEDORES>();
            this.COM_DET_DEV = new HashSet<COM_DET_DEV>();
            this.COM_DET_ORDEN = new HashSet<COM_DET_ORDEN>();
            this.COM_PROVEEDOR = new HashSet<COM_PROVEEDOR>();
            this.CON_CENTRO_COSTOS = new HashSet<CON_CENTRO_COSTOS>();
            this.CON_CUENTA_PLAN = new HashSet<CON_CUENTA_PLAN>();
            this.CON_DIARIO_AUX = new HashSet<CON_DIARIO_AUX>();
            this.CON_DIARIO_CAB = new HashSet<CON_DIARIO_CAB>();
            this.CON_DIARIO_DET = new HashSet<CON_DIARIO_DET>();
            this.CON_DIARIO_SECUENCIA = new HashSet<CON_DIARIO_SECUENCIA>();
            this.INV_ARTICULOS = new HashSet<INV_ARTICULOS>();
            this.INV_CAB_KARDEX = new HashSet<INV_CAB_KARDEX>();
            this.INV_CAB_MOVIMIENTO = new HashSet<INV_CAB_MOVIMIENTO>();
            this.INV_CAB_SOLICITUD = new HashSet<INV_CAB_SOLICITUD>();
            this.INV_CATEGORIA = new HashSet<INV_CATEGORIA>();
            this.INV_DET_KARDEX = new HashSet<INV_DET_KARDEX>();
            this.INV_DET_MOVIMIENTO = new HashSet<INV_DET_MOVIMIENTO>();
            this.INV_DET_SOLICITUD = new HashSet<INV_DET_SOLICITUD>();
            this.INV_MARCA = new HashSet<INV_MARCA>();
            this.INV_SUBTIPO = new HashSet<INV_SUBTIPO>();
            this.INV_TIPO_ARTICULO = new HashSet<INV_TIPO_ARTICULO>();
            this.INV_TIPSUBART = new HashSet<INV_TIPSUBART>();
            this.NOM_EMPLEADO_TIPO = new HashSet<NOM_EMPLEADO_TIPO>();
            this.NOM_EMPLEADOS = new HashSet<NOM_EMPLEADOS>();
            this.NOM_VENDEDOR_TIPO = new HashSet<NOM_VENDEDOR_TIPO>();
            this.NOM_VENDEDORES = new HashSet<NOM_VENDEDORES>();
            this.SEG_APLICACION = new HashSet<SEG_APLICACION>();
            this.SEG_BANCO = new HashSet<SEG_BANCO>();
            this.SEG_BODEGA = new HashSet<SEG_BODEGA>();
            this.SEG_CAB_PURGA = new HashSet<SEG_CAB_PURGA>();
            this.SEG_CENTRO_COSTO = new HashSet<SEG_CENTRO_COSTO>();
            this.SEG_CIUDAD = new HashSet<SEG_CIUDAD>();
            this.SEG_CTA_BANCO = new HashSet<SEG_CTA_BANCO>();
            this.SEG_DEPARTAMENTO = new HashSet<SEG_DEPARTAMENTO>();
            this.SEG_DET_PURGA = new HashSet<SEG_DET_PURGA>();
            this.SEG_ENT_TIP = new HashSet<SEG_ENT_TIP>();
            this.SEG_ENTIDAD = new HashSet<SEG_ENTIDAD>();
            this.SEG_ESTADO_AI1 = new HashSet<SEG_ESTADO_AI>();
            this.SEG_GRUPO = new HashSet<SEG_GRUPO>();
            this.SEG_HISTORICO = new HashSet<SEG_HISTORICO>();
            this.SEG_IMP_BEN = new HashSet<SEG_IMP_BEN>();
            this.SEG_INICIO = new HashSet<SEG_INICIO>();
            this.SEG_MENSAJE = new HashSet<SEG_MENSAJE>();
            this.SEG_MENU = new HashSet<SEG_MENU>();
            this.SEG_NIVEL_PRECIO = new HashSet<SEG_NIVEL_PRECIO>();
            this.SEG_PAIS = new HashSet<SEG_PAIS>();
            this.SEG_PER_CON = new HashSet<SEG_PER_CON>();
            this.SEG_PERFIL_EMP = new HashSet<SEG_PERFIL_EMP>();
            this.SEG_PROVINCIA = new HashSet<SEG_PROVINCIA>();
            this.SEG_TIPO = new HashSet<SEG_TIPO>();
            this.SEG_USU_GRUPO = new HashSet<SEG_USU_GRUPO>();
            this.SEG_USUARIO2 = new HashSet<SEG_USUARIO>();
            this.SEG_ZONA = new HashSet<SEG_ZONA>();
        }
    
        public int SEG_EMPRESA_Id { get; set; }
        public string EMP_Representante { get; set; }
        public string EMP_Descripcion { get; set; }
        public string EMP_Ruc { get; set; }
        public string EMP_Direccion { get; set; }
        public string EMP_Telefono { get; set; }
        public string EMP_Fax { get; set; }
        public string EMP_Email { get; set; }
        public Nullable<int> Aud_EstadoAI_Id { get; set; }
        public Nullable<int> Aud_Usuario_Ingreso { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Ingreso { get; set; }
        public string Aud_PC_Ingreso { get; set; }
        public Nullable<int> Aud_Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Aud_Fecha_Modifica { get; set; }
        public string Aud_PC_Modifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BCO_CUENTA_BANCOS> BCO_CUENTA_BANCOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clases_Tipos> Clases_Tipos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_CAB_DEV> COM_CAB_DEV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_CAB_ORDEN> COM_CAB_ORDEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_CATEGORIA_PROVEEDORES> COM_CATEGORIA_PROVEEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_DET_DEV> COM_DET_DEV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_DET_ORDEN> COM_DET_ORDEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COM_PROVEEDOR> COM_PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_CENTRO_COSTOS> CON_CENTRO_COSTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_CUENTA_PLAN> CON_CUENTA_PLAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_DIARIO_AUX> CON_DIARIO_AUX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_DIARIO_CAB> CON_DIARIO_CAB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_DIARIO_DET> CON_DIARIO_DET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CON_DIARIO_SECUENCIA> CON_DIARIO_SECUENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_ARTICULOS> INV_ARTICULOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CAB_KARDEX> INV_CAB_KARDEX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CAB_MOVIMIENTO> INV_CAB_MOVIMIENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CAB_SOLICITUD> INV_CAB_SOLICITUD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_CATEGORIA> INV_CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_DET_KARDEX> INV_DET_KARDEX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_DET_MOVIMIENTO> INV_DET_MOVIMIENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_DET_SOLICITUD> INV_DET_SOLICITUD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_MARCA> INV_MARCA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_SUBTIPO> INV_SUBTIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_TIPO_ARTICULO> INV_TIPO_ARTICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INV_TIPSUBART> INV_TIPSUBART { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_EMPLEADO_TIPO> NOM_EMPLEADO_TIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_EMPLEADOS> NOM_EMPLEADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_VENDEDOR_TIPO> NOM_VENDEDOR_TIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOM_VENDEDORES> NOM_VENDEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_APLICACION> SEG_APLICACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_BANCO> SEG_BANCO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_BODEGA> SEG_BODEGA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_CAB_PURGA> SEG_CAB_PURGA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_CENTRO_COSTO> SEG_CENTRO_COSTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_CIUDAD> SEG_CIUDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_CTA_BANCO> SEG_CTA_BANCO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_DEPARTAMENTO> SEG_DEPARTAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_DET_PURGA> SEG_DET_PURGA { get; set; }
        public virtual SEG_ESTADO_AI SEG_ESTADO_AI { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO { get; set; }
        public virtual SEG_USUARIO SEG_USUARIO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_ENT_TIP> SEG_ENT_TIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_ENTIDAD> SEG_ENTIDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_ESTADO_AI> SEG_ESTADO_AI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_GRUPO> SEG_GRUPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_HISTORICO> SEG_HISTORICO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_IMP_BEN> SEG_IMP_BEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_INICIO> SEG_INICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_MENSAJE> SEG_MENSAJE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_MENU> SEG_MENU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_NIVEL_PRECIO> SEG_NIVEL_PRECIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PAIS> SEG_PAIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PER_CON> SEG_PER_CON { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PERFIL_EMP> SEG_PERFIL_EMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_PROVINCIA> SEG_PROVINCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_TIPO> SEG_TIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_USU_GRUPO> SEG_USU_GRUPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_USUARIO> SEG_USUARIO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEG_ZONA> SEG_ZONA { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinica_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Receta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Receta()
        {
            this.Tb_Detalle_Receta = new HashSet<Tb_Detalle_Receta>();
        }
    
        public string cod_rec { get; set; }
        public System.DateTime Fec_reg { get; set; }
        public string cod_ate { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public string Est_rec { get; set; }
    
        public virtual Tb_Atencion Tb_Atencion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalle_Receta> Tb_Detalle_Receta { get; set; }
    }
}

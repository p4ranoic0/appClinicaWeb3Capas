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
    
    public partial class Tb_Seguro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Seguro()
        {
            this.Tb_Paciente = new HashSet<Tb_Paciente>();
        }
    
        public string cod_seg { get; set; }
        public string nom_sug { get; set; }
        public string telf_sug { get; set; }
        public string tip_sug { get; set; }
        public Nullable<decimal> desc_sug { get; set; }
        public string dir_sug { get; set; }
        public string cod_ubigeo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Paciente> Tb_Paciente { get; set; }
    }
}
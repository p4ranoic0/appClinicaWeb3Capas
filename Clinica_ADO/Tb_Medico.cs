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
    
    public partial class Tb_Medico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Medico()
        {
            this.Tb_Atencion = new HashSet<Tb_Atencion>();
        }
    
        public string cod_med { get; set; }
        public string cod_espec { get; set; }
        public string nom_med { get; set; }
        public string ape_med { get; set; }
        public string dir_med { get; set; }
        public string comen_est_pac { get; set; }
        public string email { get; set; }
        public string telf { get; set; }
        public string genero { get; set; }
        public Nullable<System.DateTime> fech_nac_med { get; set; }
        public string num_colegiatura { get; set; }
        public System.DateTime Fec_reg { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<int> Est_med { get; set; }
        public string cod_ubigeo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Atencion> Tb_Atencion { get; set; }
        public virtual Tb_Especialidad Tb_Especialidad { get; set; }
        public virtual Tb_Ubigeo Tb_Ubigeo { get; set; }
    }
}

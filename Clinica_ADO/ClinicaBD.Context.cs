﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicaDBEntities : DbContext
    {
        public ClinicaDBEntities()
            : base("name=ClinicaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tb_Atencion> Tb_Atencion { get; set; }
        public virtual DbSet<Tb_Detalle_Receta> Tb_Detalle_Receta { get; set; }
        public virtual DbSet<Tb_Especialidad> Tb_Especialidad { get; set; }
        public virtual DbSet<Tb_Laboratorio> Tb_Laboratorio { get; set; }
        public virtual DbSet<Tb_Medicamento> Tb_Medicamento { get; set; }
        public virtual DbSet<Tb_Medico> Tb_Medico { get; set; }
        public virtual DbSet<Tb_Receta> Tb_Receta { get; set; }
        public virtual DbSet<Tb_Seguro> Tb_Seguro { get; set; }
        public virtual DbSet<Tb_Sucursal> Tb_Sucursal { get; set; }
        public virtual DbSet<Tb_Ubigeo> Tb_Ubigeo { get; set; }
        public virtual DbSet<Tb_Paciente> Tb_Paciente { get; set; }
    }
}

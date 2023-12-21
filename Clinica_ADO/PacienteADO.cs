using Clinica_ADO;
using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_ADO
{
    public class PacienteADO
    {


        public PacienteBE ObtenerPacientePorDni(string dni)
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();
                
                // Realiza la consulta a la base de datos
                var pacienteEntity = _dbContext.Tb_Paciente.SingleOrDefault(p => p.dni == dni || p.cod_pac ==dni);

                if (pacienteEntity == null) {
                    throw new Exception("No se encontraron datos con el DNI ingresado");
                }
                PacienteBE pacienteBE = ConvertirAPacienteBE(pacienteEntity);
                return pacienteBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<PacienteBE> ListarPacientes()
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();

                var pacientesEntities = _dbContext.Tb_Paciente.ToList();

                var pacienteList= ConvertirAPacientesBE(pacientesEntities);

                // Ordena la lista por el nombre del médico
                pacienteList.Sort((paciente1, paciente2) => string.Compare(paciente1.NombreCompleto, paciente2.NombreCompleto, StringComparison.Ordinal));
                return pacienteList;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private List<PacienteBE> ConvertirAPacientesBE(List<Tb_Paciente> pacientesEntities)
        {
            try
            {
                return pacientesEntities.Select(p => new PacienteBE
                {
                    Cod_pac = p.cod_pac ?? string.Empty,
                    Nom_pac = p.nom_pac ?? string.Empty,
                    Ape_pac = p.ape_pac ?? string.Empty,
                    Genero = p.genero ?? string.Empty,
                    Telf = p.telf ?? string.Empty,
                    Comen_pac = p.comen_pac ?? string.Empty,
                    Dir_pac = p.dir_pac ?? string.Empty,
                    Email = p.email ?? string.Empty,
                    Fech_nac_pac = p.fech_nac_pac ?? DateTime.MinValue,
                    Sangre = p.sangre ?? string.Empty,
                    Cod_seg = p.cod_seg ?? string.Empty,
                    Usu_Registro1 = p.Usu_Registro ?? string.Empty,
                    Fec_Ult_Mod1 = p.Fec_Ult_Mod ?? DateTime.MinValue,
                    Usu_Ult_Mod1 = p.Usu_Ult_Mod ?? string.Empty,
                    Est_pac = p.est_pac ?? string.Empty,
                    Cod_ubigeo = p.cod_ubigeo ?? string.Empty,
                    Dni = p.dni ?? string.Empty,
                    NombreCompleto = p.nom_pac + " " + p.ape_pac ?? string.Empty
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al convertir pacientes: {ex.Message}");
            }

        }
        public string NombreSeguro(string cod_seguro)
        {

            ClinicaDBEntities _dbContext = new ClinicaDBEntities();
            // Realiza la consulta a la base de datos
            var pacienteEntity = _dbContext.Tb_Paciente.SingleOrDefault(p => p.cod_seg == cod_seguro);
            return pacienteEntity.Tb_Seguro.nom_sug;
        }


        private PacienteBE ConvertirAPacienteBE(Tb_Paciente pacienteEntity)
        {

            try
            {
                PacienteBE pacienteBE = new PacienteBE
                {
                    Cod_pac = pacienteEntity.cod_pac ?? string.Empty,
                    Nom_pac = pacienteEntity.nom_pac ?? string.Empty,
                    Ape_pac = pacienteEntity.ape_pac ?? string.Empty,
                    Genero = pacienteEntity.genero ?? string.Empty,
                    Telf = pacienteEntity.telf ?? string.Empty,
                    Comen_pac = pacienteEntity.comen_pac ?? string.Empty,
                    Dir_pac = pacienteEntity.dir_pac ?? string.Empty,
                    Email = pacienteEntity.email ?? string.Empty,
                    Fech_nac_pac = pacienteEntity.fech_nac_pac ?? DateTime.MinValue,
                    Sangre = pacienteEntity.sangre ?? string.Empty,
                    Cod_seg = pacienteEntity.cod_seg ?? string.Empty,
                    Usu_Registro1 = pacienteEntity.Usu_Registro ?? string.Empty,
                    Fec_Ult_Mod1 = pacienteEntity.Fec_Ult_Mod ?? DateTime.MinValue,
                    Usu_Ult_Mod1 = pacienteEntity.Usu_Ult_Mod ?? string.Empty,
                    Est_pac = pacienteEntity.est_pac ?? string.Empty,
                    Cod_ubigeo = pacienteEntity.cod_ubigeo ?? string.Empty,
                    Dni = pacienteEntity.dni ?? string.Empty,
                NombreCompleto = pacienteEntity.nom_pac +" "+ pacienteEntity.ape_pac?? string.Empty    
                };
                return pacienteBE;

            }
            catch (Exception ex)
            {
                // Puedes registrar información sobre el error y los datos problemáticos
              throw new Exception($"Error al convertir paciente. ID: {pacienteEntity.cod_pac}, Error: {ex.Message}");
                // También puedes agregar registros de error a un archivo de registro o a otra estructura de datos.
            }

        }
        public int ObtenerCantidadAtencionesPorPaciente(string dni)
        {
            ClinicaDBEntities _dbContext = new ClinicaDBEntities();
            return _dbContext.Tb_Atencion.Count(a => a.Tb_Paciente.dni == dni);
        }
    }

}

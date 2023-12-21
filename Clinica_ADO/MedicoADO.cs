using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_ADO
{
    public class MedicoADO
    {
        public string ConsultarNombreMedicoPorCod(string codMedico)
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();

                // Busca el médico por su código
                var medico = _dbContext.Tb_Medico.FirstOrDefault(m => m.cod_med == codMedico);

                if (medico != null)
                {
                    // Devuelve el nombre del médico
                    return medico.nom_med;
                }
                else
                {
                    throw new Exception($"No se encontró el médico con código {codMedico}");
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MedicoBE> ListarMedicos()
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();
                var medicosEntities = _dbContext.Tb_Medico.ToList();
                var medicosBEList = ConvertirAMedicosBE(medicosEntities);
               
                // Ordena la lista por el nombre del médico
                medicosBEList.Sort((medico1, medico2) => string.Compare(medico1.NombreCompleto, medico2.NombreCompleto, StringComparison.Ordinal));

                return medicosBEList;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private List<MedicoBE> ConvertirAMedicosBE(List<Tb_Medico> medicosEntities)
        {
            // Realiza la conversión de Tb_Medico a MedicoBE
            return medicosEntities.Select(m => new MedicoBE
            {
                Cod_med = m.cod_med ?? string.Empty,
                Cod_espec = m.cod_espec ?? string.Empty,
                Nom_med = m.nom_med ?? string.Empty,
                Ape_med = m.ape_med ?? string.Empty,
                
                Dir_med = m.dir_med ?? string.Empty,
                Comen_est_pac = m.comen_est_pac ?? string.Empty,
                Email = m.email ?? string.Empty,
                Telf = m.telf ?? string.Empty,
                Genero = m.genero ?? string.Empty,
                Fech_nac_med = m.fech_nac_med ?? DateTime.MinValue,
                Num_colegiatura = m.num_colegiatura ?? string.Empty,
                Fec_reg1 = m.Fec_reg,
                Usu_Registro1 = m.Usu_Registro ?? string.Empty,
                Fec_Ult_Mod1 = m.Fec_Ult_Mod ?? DateTime.MinValue,
                Usu_Ult_Mod1 = m.Usu_Ult_Mod ?? string.Empty,
                Est_med1 = m.Est_med ?? 0,
                Cod_ubigeo = m.cod_ubigeo ?? string.Empty,
                NombreCompleto = m.nom_med + " " + m.ape_med
            }).ToList();
        }


    }

}

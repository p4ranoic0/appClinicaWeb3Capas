using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_ADO
{
    public class AtencionADO
    {

        public string ConsultarNombreSucursalPorCod(string codSuc)
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();

                // Busca el médico por su código
                var sucursal = _dbContext.Tb_Sucursal.FirstOrDefault(m => m.cod_suc == codSuc);

                if (sucursal != null)
                {
                    // Devuelve el nombre del médico
                    return sucursal.nom_suc;
                }
                else
                {
                    throw new Exception($"No se encontró el médico con código {codSuc}");
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<AtencionBE> ListarAtencion()
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();
                // Realiza la consulta a la base de datos para obtener todas las atenciones
                var atencionesEntities = _dbContext.Tb_Atencion.ToList();
                if (atencionesEntities != null)
                {
                    List<AtencionBE> atencionesBE = ConvertirAAtencionesBE(atencionesEntities);
                    return atencionesBE;
                }
                else {
                    throw new Exception("No se encontraron datos");
                }
                
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AtencionBE> ListarAtencionPorPaciente(string cod_pac) {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();
                
                // Realiza la consulta a la base de datos para obtener todas las atenciones
                var atencionesEntities = _dbContext.Tb_Atencion
                                                    .Where(a => a.cod_pac == cod_pac)
                                                    .ToList();

                if (atencionesEntities.Any())
                {
                    return ConvertirAAtencionesBE(atencionesEntities);
                }
                else
                {
                    // Devuelve una lista vacía o nula en lugar de lanzar una excepción
                    return null;
                }

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        } 



        public List<SucursalBE> ListarSucursal()
        {
            try
            {
                ClinicaDBEntities _dbContext = new ClinicaDBEntities();
                var sucursalesEntities = _dbContext.Tb_Sucursal.ToList();
                return ConvertirASucursalesBE(sucursalesEntities);
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private List<SucursalBE> ConvertirASucursalesBE(List<Tb_Sucursal> sucursalesEntities)
        {
            // Realiza la conversión de Tb_Sucursal a SucursalBE
            return sucursalesEntities.Select(s => new SucursalBE
            {
                Cod_suc = s.cod_suc,
                Nom_suc = s.nom_suc,
                Dir_suc = s.dir_suc,
                Telf_suc = s.telf_suc,
                Cod_ubigeo = s.cod_ubigeo,
            }).ToList();
        }

        public List<AtencionBE> ConsultarAtencionesPorPaciente(string codigoPaciente)
        {
            throw new NotImplementedException();
        }

        private List<AtencionBE> ConvertirAAtencionesBE(List<Tb_Atencion> atencionesEntities)
        {
            // Realiza la conversión de Tb_Atencion a AtencionBE
            return atencionesEntities.Select(a => new AtencionBE
            {
                Cod_ate = a.cod_ate ?? string.Empty, // Puedes elegir un valor predeterminado en caso de que sea nulo
                Cod_med = a.cod_med ?? string.Empty,
                Comen_ate = a.comen_ate ?? string.Empty,
                Est_ate = a.est_ate ?? string.Empty,
                Num_sala = a.num_sala ?? string.Empty,
                Fec_reg1 = a.Fec_reg ,
                Usu_Registro1 = a.Usu_Registro ?? string.Empty,
                Fec_Ult_Mod1 = a.Fec_Ult_Mod ?? DateTime.MinValue,
                Usu_Ult_Mod1 = a.Usu_Ult_Mod ?? string.Empty,
                Cod_suc = a.cod_suc ?? string.Empty,
                Cod_pac = a.cod_pac ?? string.Empty

            }).ToList();
        }

    }
}

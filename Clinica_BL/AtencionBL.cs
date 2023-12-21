using Clinica_ADO;
using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_BL
{
    public class AtencionBL
    {
     AtencionADO objAtencionADO = new AtencionADO();

        public string ConsultarNombreSucursalPorCod(string codSuc)
        {
            return objAtencionADO.ConsultarNombreSucursalPorCod(codSuc);
        }

            public List<AtencionBE> ListarAtencion()
        {
            return objAtencionADO.ListarAtencion();
        }

        public List<AtencionBE> ListarAtencionPorPaciente(string cod_pac)
        {
            return objAtencionADO.ListarAtencionPorPaciente(cod_pac);
        }

            public List<SucursalBE> ListarSucursal()
        {
            return objAtencionADO.ListarSucursal();
        }
        public List<AtencionBE> ConsultarAtencionesPorPaciente(string codigoPaciente)
        {
            return objAtencionADO.ConsultarAtencionesPorPaciente(codigoPaciente);
        }

    }
}

using Clinica_ADO;
using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_BL
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();


        public PacienteBE ObtenerPacientePorDni(string dni)
        {
            return objPacienteADO.ObtenerPacientePorDni(dni);

        }
        public int ObtenerCantidadAtencionesPorPaciente(string dni)
        {
            return objPacienteADO.ObtenerCantidadAtencionesPorPaciente(dni);
        }

        public List<PacienteBE> ListarPacientes()
        {
            return objPacienteADO.ListarPacientes();
        }
        public string NombreSeguro(string cod_seguro)
        {
            return objPacienteADO.NombreSeguro(cod_seguro);
        }
    }
}

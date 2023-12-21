using Clinica_ADO;
using Clinica_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_BL
{
    public class MedicoBL
    {
        MedicoADO medicoADO = new MedicoADO();
        public string ConsultarNombreMedicoPorCod(string codMedico) {
            return medicoADO.ConsultarNombreMedicoPorCod(codMedico);
        }

        public List<MedicoBE> ListarMedicos()
        {
            return medicoADO.ListarMedicos();
        }
    }
}

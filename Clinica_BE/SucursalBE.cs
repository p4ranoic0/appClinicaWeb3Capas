using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_BE
{
    public class SucursalBE
    {
        private string cod_suc;
        private string nom_suc;
        private string dir_suc;
        private string telf_suc;
        private string cod_ubigeo;

        public string Cod_suc { get => cod_suc; set => cod_suc = value; }
        public string Nom_suc { get => nom_suc; set => nom_suc = value; }
        public string Dir_suc { get => dir_suc; set => dir_suc = value; }
        public string Telf_suc { get => telf_suc; set => telf_suc = value; }
        public string Cod_ubigeo { get => cod_ubigeo; set => cod_ubigeo = value; }
    }
}

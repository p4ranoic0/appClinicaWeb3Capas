using System;

namespace Clinica_BE
{
    public class RecetaBE
    {
        private string cod_rec;
        private DateTime Fec_reg;
        private string cod_ate;
        private string Usu_Registro;
        private DateTime Fec_Ult_Mod;
        private string Usu_Ult_Mod;
        private string Est_rec;
        private string Estado;

        public string Cod_rec { get => cod_rec; set => cod_rec = value; }
        public DateTime Fec_reg1 { get => Fec_reg; set => Fec_reg = value; }
        public string Cod_ate { get => cod_ate; set => cod_ate = value; }
        public string Usu_Registro1 { get => Usu_Registro; set => Usu_Registro = value; }
        public DateTime Fec_Ult_Mod1 { get => Fec_Ult_Mod; set => Fec_Ult_Mod = value; }
        public string Usu_Ult_Mod1 { get => Usu_Ult_Mod; set => Usu_Ult_Mod = value; }
        public string Est_rec1 { get => Est_rec; set => Est_rec = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
    }
}

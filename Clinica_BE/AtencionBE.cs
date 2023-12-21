using System;

namespace Clinica_BE
{
    public class AtencionBE
    {
        private string cod_ate;
        private string cod_med;
        private string comen_ate;
        private string est_ate;
        private string num_sala;
        private DateTime Fec_reg;
        private string Usu_Registro;
        private DateTime Fec_Ult_Mod;
        private string Usu_Ult_Mod;
        private string cod_suc;
        private string cod_pac;

        public string Cod_ate { get => cod_ate; set => cod_ate = value; }
        public string Cod_med { get => cod_med; set => cod_med = value; }
        public string Comen_ate { get => comen_ate; set => comen_ate = value; }
        public string Est_ate { get => est_ate; set => est_ate = value; }
        public string Num_sala { get => num_sala; set => num_sala = value; }
        public DateTime Fec_reg1 { get => Fec_reg; set => Fec_reg = value; }
        public string Usu_Registro1 { get => Usu_Registro; set => Usu_Registro = value; }
        public DateTime Fec_Ult_Mod1 { get => Fec_Ult_Mod; set => Fec_Ult_Mod = value; }
        public string Usu_Ult_Mod1 { get => Usu_Ult_Mod; set => Usu_Ult_Mod = value; }
        public string Cod_suc { get => cod_suc; set => cod_suc = value; }
        public string Cod_pac { get => cod_pac; set => cod_pac = value; }
    }
}

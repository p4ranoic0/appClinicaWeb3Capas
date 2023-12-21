using System;

namespace Clinica_BE
{
    public class MedicamentoBE
    {
        private string cod_medi;
        private string nom_medi;
        private string comp_medi;
        private string cod_lab;
        private string mlgr_medi;
        private DateTime Fec_reg;
        private string Usu_Registro;
        private DateTime Fec_Ult_Mod;
        private string Usu_Ult_Mod;
        private int Est_medi;

        public string Cod_medi { get => cod_medi; set => cod_medi = value; }
        public string Nom_medi { get => nom_medi; set => nom_medi = value; }
        public string Comp_medi { get => comp_medi; set => comp_medi = value; }
        public string Cod_lab { get => cod_lab; set => cod_lab = value; }
        public string Mlgr_medi { get => mlgr_medi; set => mlgr_medi = value; }
        public DateTime Fec_reg1 { get => Fec_reg; set => Fec_reg = value; }
        public string Usu_Registro1 { get => Usu_Registro; set => Usu_Registro = value; }

        public string Usu_Ult_Mod1 { get => Usu_Ult_Mod; set => Usu_Ult_Mod = value; }
        public int Est_medi1 { get => Est_medi; set => Est_medi = value; }
        public DateTime Fec_Ult_Mod1 { get => Fec_Ult_Mod; set => Fec_Ult_Mod = value; }
    }
}

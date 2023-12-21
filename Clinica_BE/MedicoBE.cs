using System;

namespace Clinica_BE
{
    public class MedicoBE
    {
        private string cod_med;
        private string cod_espec;
        private string nom_med;
        private string ape_med;
        private string dir_med;
        private string comen_est_pac;
        private string email;
        private string telf;
        private string genero;
        private DateTime fech_nac_med;
        private string num_colegiatura;
        private DateTime Fec_reg;
        private string Usu_Registro;
        private DateTime Fec_Ult_Mod;
        private string Usu_Ult_Mod;
        private int Est_med;
        private string cod_ubigeo;
        private string nombreCompleto;


        public string Cod_med { get => cod_med; set => cod_med = value; }
        public string Cod_espec { get => cod_espec; set => cod_espec = value; }
        public string Nom_med { get => nom_med; set => nom_med = value; }
        public string Ape_med { get => ape_med; set => ape_med = value; }
        public string Dir_med { get => dir_med; set => dir_med = value; }
        public string Comen_est_pac { get => comen_est_pac; set => comen_est_pac = value; }
        public string Email { get => email; set => email = value; }
        public string Telf { get => telf; set => telf = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime Fech_nac_med { get => fech_nac_med; set => fech_nac_med = value; }
        public string Num_colegiatura { get => num_colegiatura; set => num_colegiatura = value; }
        public DateTime Fec_reg1 { get => Fec_reg; set => Fec_reg = value; }
        public string Usu_Registro1 { get => Usu_Registro; set => Usu_Registro = value; }
        public DateTime Fec_Ult_Mod1 { get => Fec_Ult_Mod; set => Fec_Ult_Mod = value; }
        public string Usu_Ult_Mod1 { get => Usu_Ult_Mod; set => Usu_Ult_Mod = value; }
        public int Est_med1 { get => Est_med; set => Est_med = value; }
        public string Cod_ubigeo { get => cod_ubigeo; set => cod_ubigeo = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}

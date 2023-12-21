using System;

namespace Clinica_BE
{
    public class PacienteBE
    {
        private string cod_pac;
        private string nom_pac;
        private string ape_pac;
        private string genero;
        private string telf;
        private string comen_pac;
        private string dir_pac;
        private string email;
        private DateTime fech_nac_pac;
        private string sangre;
        private string cod_seg;
        private string Usu_Registro;
        private DateTime Fec_Ult_Mod;
        private string Usu_Ult_Mod;
        private string est_pac;
        private string cod_ubigeo;
        private string nom_sug;
        private string dni;
        private string nombreCompleto;

        public string Cod_pac { get => cod_pac; set => cod_pac = value; }
        public string Nom_pac { get => nom_pac; set => nom_pac = value; }
        public string Ape_pac { get => ape_pac; set => ape_pac = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Telf { get => telf; set => telf = value; }
        public string Comen_pac { get => comen_pac; set => comen_pac = value; }
        public string Dir_pac { get => dir_pac; set => dir_pac = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Fech_nac_pac { get => fech_nac_pac; set => fech_nac_pac = value; }
        public string Sangre { get => sangre; set => sangre = value; }
        public string Cod_seg { get => cod_seg; set => cod_seg = value; }
        public string Usu_Registro1 { get => Usu_Registro; set => Usu_Registro = value; }
        public DateTime Fec_Ult_Mod1 { get => Fec_Ult_Mod; set => Fec_Ult_Mod = value; }
        public string Usu_Ult_Mod1 { get => Usu_Ult_Mod; set => Usu_Ult_Mod = value; }
        public string Est_pac { get => est_pac; set => est_pac = value; }
        public string Cod_ubigeo { get => cod_ubigeo; set => cod_ubigeo = value; }
        public string Nom_sug { get => nom_sug; set => nom_sug = value; }
        public string Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}

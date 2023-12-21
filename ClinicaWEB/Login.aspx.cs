using System;

namespace ClinicaWEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {

                // Usuario y password obligatorios
                if (txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el usuario.");
                }

                if (txtPass.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el password.");
                }


                // Validamos el usuario y contraseña

                if (txtUsuario.Text.Trim() == "clinica@gmail.com" & txtPass.Text.Trim() == "12345")
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    throw new Exception("Usuario o password errados.");
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}
using Clinica_BE;
using Clinica_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaWEB.Reportes
{
    public partial class Reporte2 : System.Web.UI.Page
    {
        PacienteBL pacienteBL = new PacienteBL();
        AtencionBL atencionBL = new AtencionBL();
        MedicoBL medicoBL = new MedicoBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                // Ocultar el GridView y el mensaje de sin atenciones al cargar la página
                gvAtenciones.Visible = false;
                lblSinAtenciones.Visible = false;
            }
        }

        protected void btnBuscarPacientePorDni_Click(object sender, EventArgs e)
        {

            string dni = txtDni.Text.Trim();
            LimpiarDatosPaciente();

            // Validar que se ingresó un DNI
            if (string.IsNullOrEmpty(dni))
            {
                // Muestra un mensaje de error si el DNI está vacío
                MostrarError("Ingrese un número de DNI válido.");
                return;
            }
            else
            {

                CargarDatosPaciente();

            }

        }

        private void CargarDatosPaciente()
        {
            PacienteBE pacienteBE = new PacienteBE();
            try
            {
                pacienteBE = pacienteBL.ObtenerPacientePorDni(txtDni.Text);


                lblNombrePac.Text = pacienteBE.NombreCompleto;
                lblGenero.Text = pacienteBE.Genero == "M" ? "Masculino" : "Femenino";
                lblFechaNacimiento.Text = pacienteBE.Fech_nac_pac.ToShortDateString();
                lblTelefono.Text = pacienteBE.Telf;
                lblDni.Text = pacienteBE.Dni;
                lblDireccion.Text = pacienteBE.Dir_pac;
                lblEmail.Text = pacienteBE.Email;
                lblGrupoSanguineo.Text = pacienteBE.Sangre;
                lblSeguro.Text = pacienteBL.NombreSeguro(pacienteBE.Cod_seg);
                CargarGridAtenciones(pacienteBE.Cod_pac);
            }

            catch (Exception ex)
            {
                MostrarError($"error al obtener datos del paciente {ex.Message}");
            }

        }

        private void CargarGridAtenciones(string cod_pac)
        {
            try
            {
                List<AtencionBE> atenciones = atencionBL.ListarAtencionPorPaciente(cod_pac);

                gvAtenciones.DataSource = atenciones;
                gvAtenciones.DataBind();

                gvAtenciones.Visible = true;
            }
            catch (Exception ex)
            {

                MostrarError($"error al obtener datos de atenciones {ex.Message}");
            }
        }

        protected string ObtenerNombreMedico(object cod_med)
        {
            List<MedicoBE> listaMedicos = medicoBL.ListarMedicos();

            var medicoFiltrado = listaMedicos.FirstOrDefault(m => m.Cod_med == cod_med.ToString());

            if (medicoFiltrado != null)
            {
                return $"{medicoFiltrado.NombreCompleto}";
            }
            else
            {
                return "Médico no encontrado";
            }
        }

        protected string ObtenerNombreSucursal(object cod_suc)
        {
            List<SucursalBE> listarSucursal = atencionBL.ListarSucursal();

            var sucursalFiltrada = listarSucursal.FirstOrDefault(m => m.Cod_suc == cod_suc.ToString());

            if (sucursalFiltrada != null)
            {
                return $"{sucursalFiltrada.Nom_suc}";
            }
            else
            {
                return "Médico no encontrado";
            }
        }

        private void LimpiarDatosPaciente()
        {
            // Limpiar los datos del paciente en la vista
            lblNombrePac.Text = string.Empty;
            lblGenero.Text = string.Empty;
            lblFechaNacimiento.Text = string.Empty;
            lblTelefono.Text = string.Empty;
            lblDni.Text = string.Empty; 
            lblDireccion.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblGrupoSanguineo.Text = string.Empty;
            lblSeguro.Text = string.Empty;

            gvAtenciones.DataSource = null;
            gvAtenciones.SelectedIndex = -1;
            gvAtenciones.DataBind();
            gvAtenciones.Visible = false;

        }

        protected void gvAtenciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAtenciones.PageIndex = e.NewPageIndex;

        }
        private void MostrarError(string message)
        {
            ((PageMaster)Master).MostrarToast("Error", "danger", message);
        }
    }
}
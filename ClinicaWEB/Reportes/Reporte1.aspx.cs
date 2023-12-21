using Clinica_BE;
using Clinica_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace ClinicaWEB.Reportes
{
    public partial class Reporte1 : System.Web.UI.Page
    {
        private readonly AtencionBL atencionBL = new AtencionBL();
        private readonly MedicoBL medicoBL = new MedicoBL();
        private readonly PacienteBL pacienteBL = new PacienteBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    InicializarVista();
                    CargarMedico();
                    CargarPaciente();
                    CargarSucursal();
                }
                catch (Exception ex)
                {
                    MostrarError(ex.Message);
                }
            }
        }

        private void InicializarVista()
        {
            gvAtencion.DataSource = atencionBL.ListarAtencion();
            gvAtencion.DataBind();
        }

        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }    

        private void CargarDatos()
        {
            try
            {
                List<AtencionBE> listaAtenciones = atencionBL.ListarAtencion();

                // Filtra la lista usando LINQ
                var atencionesFiltradas = listaAtenciones
                    .Where(a => a.Cod_med == cboMedico.SelectedValue
                                && a.Cod_pac == cboPaciente.SelectedValue
                                && a.Cod_suc == cboSucursal.SelectedValue)
                    .ToList();

                // Enlaza la lista filtrada al GridView
                gvAtencion.DataSource = atencionesFiltradas;
                gvAtencion.DataBind();

                if (gvAtencion.Rows.Count == 0)
                {
                    MostrarError("No existen registros con el criterio ingresado.");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
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


        protected string ObtenerNombrePaciente(object cod_pac)
        {
            List<PacienteBE> listaPacientes = pacienteBL.ListarPacientes();

            var pacienteFiltrado = listaPacientes.FirstOrDefault(p => p.Cod_pac == cod_pac.ToString());

            if (pacienteFiltrado != null)
            {
                return $"{pacienteFiltrado.NombreCompleto}";
            }
            else
            {
                return "Paciente no encontrado";
            }
        }

        protected string ObtenerNombreSucursal(object cod_suc)
        {
            List<SucursalBE> listaSucursal = atencionBL.ListarSucursal();

            var sucursalFiltrado = listaSucursal.FirstOrDefault(s => s.Cod_suc == cod_suc.ToString());

            if (sucursalFiltrado != null)
            {
                return $"{sucursalFiltrado.Nom_suc} ";
            }
            else
            {
                return "Sucursal no encontrado";
            }
        }


       
        protected void gvAtencion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAtencion.PageIndex = e.NewPageIndex;
            InicializarVista();
        }

        protected void btnBuscarAtencion_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void CargarMedico()
        {
            try
            {
                List<MedicoBE> medicos = medicoBL.ListarMedicos();
                cboMedico.DataSource = medicos;
                cboMedico.DataValueField = "cod_med";
                cboMedico.DataTextField = "NombreCompleto";
                cboMedico.DataBind();
                cboMedico.Items.Insert(0, new ListItem("Seleccione", ""));
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar medicos: {ex.Message}");
            }          

        }

        private void CargarPaciente()
        {
            Console.WriteLine("Número de elementos en cboPaciente: " + cboPaciente.Items.Count);
            foreach (ListItem item in cboPaciente.Items)
            {
                Console.WriteLine("Valor: " + item.Value + ", Texto: " + item.Text);
            }

            try
            {
                List<PacienteBE> pacientes = pacienteBL.ListarPacientes();
                cboPaciente.DataSource = pacientes;
                cboPaciente.DataValueField = "cod_pac"; // Valor del campo que quieres usar al seleccionar un elemento
                cboPaciente.DataTextField = "NombreCompleto"; // Nombre del campo que quieres mostrar en el DropDownList
                cboPaciente.DataBind();
                cboPaciente.Items.Insert(0, new ListItem("Seleccione", "")); // Opcional, para agregar un ítem por defecto

            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar pacientes: {ex.Message}");
            }
        }

        private void CargarSucursal()
        {
            try
            {
                List<SucursalBE> sucursales = atencionBL.ListarSucursal();
                cboSucursal.DataSource = sucursales;
                cboSucursal.DataValueField = "cod_suc";
                cboSucursal.DataTextField = "nom_suc";
                cboSucursal.DataBind();
                cboSucursal.Items.Insert(0, new ListItem("Seleccione", ""));
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar sucursales: {ex.Message}");
            }
        }

        private void MostrarError(string message)
        {
            ((PageMaster)Master).MostrarToast("Error", "danger", message);
        }
    }
}
